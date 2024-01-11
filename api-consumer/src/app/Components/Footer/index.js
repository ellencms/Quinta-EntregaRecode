



export default function Footer() {
		return (
			<footer>
      <div id="rodape" className="container-fluid p-4">
        {/* Grid row */}
        <div className="row">
          {/* Grid column */}
          <div className="img-fluid">
            <img src="img/logo.png"  alt="Logo" width="200" height="250" />
          </div>

          {/* Grid column */}
          <div className="footer h4">
            <h4> Redes Sociais </h4>
            <a href="#" className="footer-link" id="instagram">
              <i className="fab fa-instagram fa-2x"></i>
            </a>
            <a href="#" className="footer-link" id="facebook">
              <i className="fab fa-facebook fa-2x"></i>
            </a>
            <a href="#" className="footer-link" id="whatsapp">
              <i className="fab fa-whatsapp fa-2x"></i>
            </a>
            <a href="#" className="footer-link" id="twitter">
              <i className="fab fa-twitter fa-2x"></i>
            </a>
          </div>

          {/* Grid column */}
          <div className="footer h4">
            <h4 > Formas de Pagamento</h4>
            <img src="img/pagamento.png" className="img-fluid" alt="Formas de Pagamento" width="200" height="300" />
          </div>

          {/* Copyright */}
          <div className="text-center p-3">
            <h4 className="footer h4"> &copy; 2023 Belém Tour.Todos os direitos reservados</h4>
          </div>
        </div>
      </div>
    </footer>
  )
}

