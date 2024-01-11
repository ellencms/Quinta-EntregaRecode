
using BelemTour.Model;
using Microsoft.EntityFrameworkCore;

namespace BelemTour.Data
{
   public class DataContext : DbContext 
     {
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {
            
        }

public DbSet<Destino> Destinos { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Destino>().HasData(
            new Destino {Id = 1, Nome="Salinopolis", Categoria= "Tur", Tempo ="5 Dias", Valor= 200.00M,Imagem="http://www.altaestacaoturismo.com.br/images/content/destinos/14-1.jpg"}, 

              new Destino {Id = 2, Nome="Mosqueiro", Categoria= "Passeios Regulares", Tempo ="1 semana", Valor= 499.00M, Imagem="https://scontent.fsjk9-1.fna.fbcdn.net/v/t1.6435-9/37023389_1329318750504085_4156171523704487936_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=c2f564&_nc_ohc=Q3g9qmEooD4AX_vXbAf&_nc_ht=scontent.fsjk9-1.fna&oh=00_AfA-xe3b64XOLbrlCoscdctcAM2EQZIXjKj2U1Y73aZ0uw&oe=65C675E6"}, 

              new Destino {Id = 3, Nome="Algodoal", Categoria= "Passeios Regulares", Tempo ="2 semana", Valor= 900.00M,  Imagem="https://s2-g1.glbimg.com/8csOy6Wslb86EiUyE_oloIM5oOQ=/0x0:620x465/1008x0/smart/filters:strip_icc()/s.glbimg.com/jo/g1/f/original/2012/07/25/vistaaereapraia_da_princesa-henriquefelicio.jpg"}, 

               new Destino {Id = 4, Nome="Marudá", Categoria= "Passeios Regulares", Tempo ="15 Dias", Valor= 500.00M,  Imagem="https://www.ferias.tur.br/imgs/4682/maruda/g_maruda-pa-dsc_0080.jpg"}, 

              new Destino {Id = 5, Nome="Ajuruteua", Categoria= "Passeios Regulares", Tempo ="3 semana", Valor= 1500.00M,  Imagem="https://scontent.fsjk9-1.fna.fbcdn.net/v/t39.30808-6/310595670_542403674555503_1563832596458789831_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=783fdb&_nc_ohc=bSXETuLcMNIAX-1Mhib&_nc_ht=scontent.fsjk9-1.fna&oh=00_AfDwTz-DNaBCcBSCeFCMtLGRzbZ62BdohuVXtM5yFtZ0eg&oe=65A4476F"},

              new Destino {Id = 6, Nome="Outeiro", Categoria= "Tur", Tempo =" 10 dias", Valor= 400.00M,  Imagem="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/06/0c/9a/58/praia-do-outeiro.jpg?w=900&h=600&s=1"}
             );
        }

    }

    

    }



