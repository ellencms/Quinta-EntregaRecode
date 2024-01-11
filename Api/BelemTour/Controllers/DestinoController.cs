using BelemTour.Data;
using BelemTour.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BelemTour.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DestinoController : ControllerBase
{
private readonly DataContext _dataContext;

public DestinoController (DataContext dataContext){

_dataContext= dataContext;
}

[HttpGet]
public async Task<ActionResult<IEnumerable<Destino>>> GetDestino(){

return await _dataContext.Destinos.ToListAsync();

}

[HttpGet("{id}")]

public async Task<ActionResult<Destino>> GetDestinoById( int id){

var Destino = await _dataContext.Destinos.FindAsync(id);
if(Destino== null){

return NotFound();


}
return Ok (Destino);

}


}