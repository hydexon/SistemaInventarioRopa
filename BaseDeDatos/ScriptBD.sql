
CREATE TABLE Proveedores(
    ProveedorId INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Direccion TEXT NOT NULL,
    Telefono TEXT NOT NULL,
    Email    TEXT NOT NULL,
    Representante TEXT NOT NULL
);

CREATE TABLE Clientes(
    ClienteId INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre    TEXT NOT NULL,
    DUI       TEXT NOT NULL,
    Direccion TEXT NOT NULL,
    Telefono  TEXT NOT NULL,
    Email     TEXT NOT NULL
);

CREATE TABLE Prenda_Categoria(
    CatId INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL UNIQUE
);

CREATE TABLE Prendas(
    PrendaId INTEGER PRIMARY KEY AUTOINCREMENT,
    Imagen BLOB,
    Nombre TEXT NOT NULL,
    Marca  TEXT NOT NULL,
    Stock  INTEGER NOT NULL,
    Talla  TEXT NOT NULL,
    Categoria INTEGER, -- Puede ser nulo.
    Proveedor INTEGER NOT NULL,
    PrecioCompra REAL NOT NULL,
    PrecioVenta  REAL NOT NULL,
    FOREIGN KEY(Categoria) REFERENCES Prenda_Categoria(CatId),
    FOREIGN KEY(Proveedor) REFERENCES Proveedor(ProveedorId)
);

CREATE TABLE Compras(
    CompraId INTEGER PRIMARY KEY AUTOINCREMENT,
    FechaCompra DATE NOT NULL,
    Proveedor INTEGER NOT NULL,    
    Empleado INTEGER NOT NULL,
    FOREIGN KEY(Empleado) REFERENCES Empleados(EmpleadoId),
    FOREIGN KEY(Proveedor) REFERENCES Proveedor(ProveedorId)
);

CREATE TABLE Compras_Detalle(
    CompraDetalleId INTEGER PRIMARY KEY AUTOINCREMENT,
    Compra    INTEGER NOT NULL,
    Prenda    INTEGER NOT NULL,
    Cantidad  INTEGER NOT NULL,
    FOREIGN KEY(Prenda) REFERENCES Prendas(PrendaId),
    FOREIGN KEY(Compra) REFERENCES Compras(CompraId)
);

CREATE TABLE Ventas(
    VentaId INTEGER PRIMARY KEY AUTOINCREMENT,
    FechaVenta DATE NOT NULL,
    Cliente INTEGER NOT NULL,
    Empleado INTEGER NOT NULL,
    FOREIGN KEY(Empleado) REFERENCES Empleados(EmpleadoId),
    FOREIGN KEY(Cliente) REFERENCES Clientes(ClienteId)
);

CREATE TABLE Ventas_Detalle(
    VentaDetalleId INTEGER PRIMARY KEY AUTOINCREMENT,
    Venta     INTEGER NOT NULL,
    Prenda    INTEGER NOT NULL,
    Cantidad  INTEGER NOT NULL,
    FOREIGN KEY(Prenda) REFERENCES Prendas(PrendaId),
    FOREIGN KEY(Venta)  REFERENCES Ventas(VentaId)
);

CREATE TABLE Empleados(
    EmpleadoId INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombres    TEXT NOT NULL,
    DUI        TEXT NOT NULL,
    TipoUser   INTEGER NOT NULL,
    Username   TEXT NOT NULL,
    Password   TEXT NOT NULL,
    Creacion   DATE NOT NULL
);

CREATE TRIGGER trigger_reducir_stock_antes_venta BEFORE INSERT ON Ventas_Detalle
BEGIN	
	UPDATE Prendas SET Stock = CASE WHEN Stock > NEW.Cantidad THEN Stock = Stock - NEW.Cantidad ELSE 
		RAISE(ABORT, 'El Stock del articulo es menor o nulo sobre la cantidad de ropa a vender!')
		END;
END;

CREATE TRIGGER trigger_incrementar_stock_despues_compra AFTER INSERT ON Compras_Detalle
BEGIN
    UPDATE Prendas SET Stock = Stock + NEW.Cantidad WHERE PrendaId = NEW.Prenda;
END;


CREATE TRIGGER trigger_anular_categoria_en_prendas AFTER DELETE ON Prenda_Categoria
BEGIN
    UPDATE Prendas SET Categoria = -1 WHERE Categoria = OLD.CatId;
END;

CREATE VIEW Vista_Productos AS 
SELECT Prendas.PrendaId, Prendas.Imagen, Prendas.Nombre, Prendas.Marca, Prendas.Talla, Prendas.Stock, Prenda_Categoria.Nombre AS "Categoria", 
Proveedores.Nombre AS "Proveedor", Prendas.PrecioVenta, Prendas.PrecioCompra FROM Prendas 
	INNER JOIN Proveedores ON Prendas.Proveedor = Proveedores.ProveedorId 
	INNER JOIN Prenda_Categoria ON Prendas.Categoria = Prenda_Categoria.CatId;

CREATE VIEW Vista_Productos AS
SELECT Prendas.PrendaId, Prendas.Imagen, Prendas.Nombre, Prendas.Marca, Prendas.Talla,
       Prendas.Stock, Prenda_Categoria.Nombre AS "Categoria", Proveedores.Nombre AS "Proveedor",
       Prendas.PrecioVenta, Prendas.PrecioCompra FROM Prendas 
        INNER JOIN Proveedores ON Prendas.Proveedor = Proveedores.ProveedorId
        INNER JOIN Prenda_Categoria ON Prendas.Categoria = Prenda_Categoria.CatId;
		
CREATE VIEW Vista_Compra AS
SELECT Compras.CompraId, Compras.Empleado,Compras.FechaCompra, Proveedores.Nombre AS ProveedorNombre, Proveedores.Direccion AS ProveedorDireccion,
       Proveedores.Representante AS Proveedor_Representante, Empleados.Nombres AS EmpleadoResponsable FROM Compras
        INNER JOIN Proveedores ON Compras.Proveedor = Proveedores.ProveedorId
        INNER JOIN Empleados   ON Compras.Empleado  = Empleados.EmpleadoId;

CREATE VIEW Vista_Ventas AS
SELECT Ventas.VentaId, Ventas.FechaVenta, Ventas.Empleado, Clientes.Nombre AS ClienteNombre, Clientes.DUI AS ClienteDUI, 
       Clientes.Direccion AS ClienteDireccion, Empleados.Nombres AS EmpleadoResponsable FROM Ventas
        INNER JOIN Clientes  ON Ventas.Cliente  = Clientes.ClienteId
        INNER JOIN Empleados ON Ventas.Empleado = Empleados.EmpleadoId; 

CREATE VIEW VistaDetalle_CompraPrendas AS
SELECT Prendas.PrendaId, Prendas.Nombre, Prendas.Marca, Prendas.Talla,
	Compras_Detalle.Cantidad, Prendas.PrecioCompra FROM Compras_Detalle
    INNER JOIN Prendas ON Prendas.PrendaId = Compras_Detalle.Prenda;

CREATE VIEW VistaDetalle_VentaPrendas AS
SELECT Prendas.PrendaId, Prendas.Nombre, Prendas.Marca, Prendas.Talla, 
       Ventas_Detalle.Cantidad, Prendas.PrecioVenta FROM Ventas_Detalle
       INNER JOIN Ventas_Detalle ON Prendas.PrendaId = Ventas_Detalle.Prenda;
 
