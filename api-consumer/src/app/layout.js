import Footer from './Components/Footer'
import Header from './Components/Header'
import './globals.css'
import 'bootstrap/dist/css/bootstrap.min.css'


export default function RootLayout({ children }) {
	return (
		<html lang="pt-br">
			<body>
				<Header />
				<main>{children}</main>
        <Footer/>
			</body>
		</html>
	)
}
