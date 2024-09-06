CREATE TABLE IF NOT EXISTS Estados (
    id INT PRIMARY KEY AUTO_INCREMENT,
    sigla VARCHAR(2) NOT NULL,
    nome VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS Tipos_Telefone (
    id INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS Clientes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    razao_social VARCHAR(255) NOT NULL,
    estado_id INT,
    FOREIGN KEY (estado_id) REFERENCES Estados(id)
);

CREATE TABLE IF NOT EXISTS Telefones (
    id INT PRIMARY KEY AUTO_INCREMENT,
    numero_telefone VARCHAR(20) NOT NULL,
    cliente_id INT,
    tipo_telefone_id INT,
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id),
    FOREIGN KEY (tipo_telefone_id) REFERENCES Tipos_Telefone(id)
);

SELECT c.id AS cliente_id, c.razao_social, t.numero_telefone
FROM Clientes c
JOIN Telefones t ON c.id = t.cliente_id
JOIN Estados e ON c.estado_id = e.id
WHERE e.sigla = 'SP';