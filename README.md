# Meu primeiro projeto PDI(bancoframework.console) - c#

## Script de criação do Banco de dados
CREATE DATABASE framework_pdi;

## Script de criação da tabela Cliente e seus campos
CREATE TABLE cliente (
  identificacao INT,
  nome VARCHAR(255),
  cpf VARCHAR(14),
  saldo DECIMAL(10, 2)
);