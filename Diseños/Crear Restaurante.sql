//Base_de_datos_restaurante

Create table Usuario(
	idusuario integer primary key auto_increment,
	nombreUsuario varchar(30) not null,
	apellidoUsuario varchar(30) not null,
	nit varchar(20),
	fecha_nacimiento date,
	telefono varchar(11) not null,
	direccion varchar(200) not null,
	email varchar(50) 	
);

Create table Tarjetas_de_pago(
	idtarjeta integer  primary key auto_increment,
	numeroTarjeta varchar(20) unique,
	nombrePropietario varchar(50) not null,
	CVV integer,
	fechaExpiracion date,
	idUsuario integer not null,
	foreign key (idusuario) references Usuario (idUuuario)
);

Create table Categoria_Platos(
	idcategoria integer primary key auto_increment,
	nombre varchar(25)
);

Create table Plato(
	idplato integer primary key auto_increment,
	nombrePlato varchar(50) not null,
	precio double not null,
	idcategoria integer not null,
	foreign key (idcategoria) references Categoria_Platos (idcategoria),
	imagen varchar(80)
);

Create table Pedido(
	idpedido integer primary key auto_increment,
	totalPedido double not null,
	metodoPago varchar(10) not null,
	fechaEntrega datetime not null,
	fechaOrden datetime not null	 
);

Create table Factura(
	idpedido integer not null,
	totalFactura double not null,
	nombreCliente varchar(50),
	nit integer,
	idusuario integer,
	foreign key (idusuario) references Usuario (idusuario),
	foreign key (idpedido) references Pedido (idpedido),
	primary key (idpedido) 
);

Create table Platos_Pedido(
	idplato integer not null,
	idpedido integer not null,
	foreign key (idplato) references Plato (idplato),
	foreign key (idpedido) references Pedido (idpedido),
	primary key (idplato,idpedido)  
);