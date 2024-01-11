import styles from './card.module.css'
import Link from 'next/link'




export default async function Card() {
	const cards = await fetch('http://localhost:5104/Api/Destino').then((res) => res.json(),
	);
	console.log(cards);

	return (
		<div className={styles.container}>
			{cards?.map((card) => (
				<div key={card.id} className={styles.card}>
					 <img src={card.Imagem} />

					 <div className={styles.Card}>
						<p>{card.Nome}</p>
						<p>{card.Categoria}</p>
						<p>{card.Tempo}</p>
						<p>{card.Valor}</p>
						<p>{card.Imagem}</p>

					</div>
				</div>
			))}
		</div>
	);
}
