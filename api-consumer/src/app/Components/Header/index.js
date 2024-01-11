import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">


			
		<nav className="navbar navbar-expand-lg bg-body-tertiary">

<div id="navbar" className="container-fluid">

	<a className="navbar-brand" href="index.html"> <img src="img/logo.png" width="130" height="100"/></a>
	<button className="navbar-toggler" type="button" data-bs-toggle="collapse"
		data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
		aria-expanded="false" aria-label="Toggle navigation">
		<span className="navbar-toggler-icon"></span>
	</button>

	<div className="collapse navbar-collapse" id="navbarSupportedContent">
		<ul className="navbar-nav me-auto mb-2 mb-lg-0">
			<li className="nav-item">
				<a className="nav-link active" aria-current="page" href="index.html">Home</a>
			</li>
			<li className="nav-item">
				<a className="nav-link" href="destino.html">Destino</a>
			</li>
			<li className="nav-item">
				<a className="nav-link" href="promocao.html">Promoções</a>
			</li>

			<li className="nav-item">
				<a className="nav-link" href="cadastro.html">Cadastros</a>
			</li>
			<li className="nav-item">
				<a className="nav-link" href="contatos.html">Contatos</a>
			</li>
		</ul>
		
	</div>
</div>
</nav>
<ul>
				<li>
					<Link href="/RotaUm">Link 1</Link>
				</li>
				<li>
					<Link href="/RotaDois">Link 2</Link>
				</li>
				<li>
					<Link href="/RotaTres">Link 3</Link>
				</li>
			</ul>


		</header>
	)
}