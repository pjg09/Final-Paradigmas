using BibliotecaFinalParadigmas.Clases;

Taller taller = new Taller("El desarmadero");

Cliente cliente = new Cliente("Pedro", "3052100012", true);

Gasolina carro = new Gasolina("NWK029", "Chevrolet", "Tracker", 2025, cliente, 3);

taller.IngresoCarro();