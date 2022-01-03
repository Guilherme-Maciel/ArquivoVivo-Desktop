# ARQUIVO VIVO ONLINE - DESKTOP
Gerenciador de registros, intercalado com o sistema <a href="https://github.com/Guilherme-Maciel/ArquivoVivo-Website">ARQUIVO VIVO ONLINE - WEBSITE</a>, 
oferecendo ao usuário a possibilidade de cadastrar as entidades presentes no banco e visualizar relatórios.
<br><br>
![Generic badge](https://img.shields.io/badge/Status-Finalizado-green.svg)
![Generic badge](https://img.shields.io/badge/Versão-1.0-blue.svg)<br>
![Generic badge](https://img.shields.io/badge/.net-4.6.1-purple.svg)
![Generic badge](https://img.shields.io/badge/mysql-5.7.24-purple.svg)

## Objetivos do Projeto

Projeto destinado ao trabalho de conclusão do curso técnico
de análise e desenvolvimento de sistemas, na ETEC Jardim Ângela, com o intuito
de agilizar os processos da empresa Arquivo Vivo Móveis por meio de sistemas informátizados.
<div align="center">
  <img src="https://docs.google.com/uc?id=1Gqcfq_vQOWOGJfrDzVZUfSYCZPehdair" alt="etec" height="100" align="center">
</div>

- Documentação do projeto: <a href="">click here</a>
- Site da instituição: <a href="https://etecjardimangela.com.br/">click here</a>
- Site da empresa Arquivo Vivo: ...

## Desenvolvedores

<a href="https://github.com/Guilherme-Maciel">
<div height="100">
<img src="https://docs.google.com/uc?id=19qoghb1wCPMGqa2728Awu56tzEy0p8BU" alt="demo" height="50" align="center">
<b align="center">Guilherme Maciel</b>
</div>
</a>
<br>
<a href="https://github.com/pedrolnasci">
<div height="100">
<img src="https://docs.google.com/uc?id=1YE66i4ihkTVtbJaU8AoLFjXmKgB5RH4f" alt="demo" height="50" align="center">
<b align="center">Pedro de Lima</b>
</div>
</a>
<br>
<a href="https://github.com/Reginaa15">
<div height="100">
<img src="https://docs.google.com/uc?id=1ROfAtiBEQzawtZT2h7xNHuooq58-niA4" alt="demo" height="50" align="center">
<b align="center">Regina Amorim</b>
</div>
</a>
<br>
<a href="https://github.com/JoaoSilvaOliveira">
<div height="100">
<img src="https://docs.google.com/uc?id=1PK59YTyYhmxXn538EmojSDgNfhUjZueQ" alt="demo" height="50" align="center">
<b align="center">João Silva</b>
</div>
</a>
<br>
<a href="https://github.com/CafeComLeitte">
<div height="100">
<img src="https://docs.google.com/uc?id=17pJgjIGfOjjJL6b2XgQqRDrqzN99Dr-6" alt="demo" height="50" align="center">
<b align="center">Mateus Albuquerque</b>
</div>
</a>

## Funcionalidades
- [x] Inserção de dados
- [x] Alterar dados já existentes
- [x] Relatórios de lucro e estoque por consulta SQL
- [x] Envio de email para cliente recém-cadastrado
- [x] Upload de imagens no banco de dados
- [x] Login de usuários
- [x] Filtro de busca

## Pré-requisitos
- Mysql 5.7
- Visual Studio 2017 (Recomendado)
- .NET Framework 4.6.1

## Tecnologias e Ferramentas

## Clonando o projeto
1. Abra seu Visual Studio 2017
2. Clique em: `Exibir > Team Explorer`
3. Em `Repositórios Git Locais`, clique em `Clonar`
4. Defina o local e insira a URL a seguir:
```
https://github.com/Guilherme-Maciel/ArquivoVivo-Desktop.git
```
5. Clique em `Clonar` e abra a solução do projeto
6. Em seu servidor local, crie o banco de dados e as tabelas a seguir:
```sql
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para arquivovivomv
CREATE DATABASE IF NOT EXISTS `arquivovivomv` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;
USE `arquivovivomv`;

-- Copiando estrutura para tabela arquivovivomv.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `c_id` int(11) NOT NULL AUTO_INCREMENT,
  `c_telCel` varchar(16) DEFAULT NULL,
  `c_cidade` varchar(150) DEFAULT NULL,
  `c_nome` varchar(100) DEFAULT NULL,
  `c_rua` varchar(150) DEFAULT NULL,
  `c_bairro` varchar(150) DEFAULT NULL,
  `c_sobrenome` varchar(150) DEFAULT NULL,
  `c_telFixo` varchar(16) DEFAULT NULL,
  `c_numRes` varchar(11) DEFAULT NULL,
  `c_email` varchar(200) DEFAULT NULL,
  `c_senha` varchar(20) DEFAULT NULL,
  `c_cep` varchar(9) DEFAULT NULL,
  `c_complemento` varchar(100) DEFAULT NULL,
  `c_estado` varchar(150) DEFAULT NULL,
  `c_dtReg` datetime DEFAULT NULL,
  `c_state` enum('ativo','arquivado') DEFAULT NULL,
  PRIMARY KEY (`c_id`),
  UNIQUE KEY `c_email` (`c_email`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Copiando estrutura para tabela arquivovivomv.funcionarios
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `f_id` int(11) NOT NULL AUTO_INCREMENT,
  `f_senha` varchar(20) DEFAULT NULL,
  `f_nome` varchar(100) DEFAULT NULL,
  `f_sobrenome` varchar(150) DEFAULT NULL,
  `f_email` varchar(200) DEFAULT NULL,
  `f_telCel` varchar(16) DEFAULT NULL,
  `f_telFixo` varchar(16) DEFAULT NULL,
  `f_dtReg` datetime DEFAULT NULL,
  `f_state` enum('ativo','arquivado') DEFAULT NULL,
  `f_type` enum('1','2') DEFAULT NULL,
  PRIMARY KEY (`f_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Copiando estrutura para tabela arquivovivomv.designers
CREATE TABLE IF NOT EXISTS `designers` (
  `d_id` int(11) NOT NULL AUTO_INCREMENT,
  `d_nome` varchar(100) DEFAULT NULL,
  `d_bio` varchar(500) DEFAULT NULL,
  `d_imagem` mediumblob,
  `f_id` int(11) DEFAULT NULL,
  `d_typeImg` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`d_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Copiando estrutura para tabela arquivovivomv.categoria
CREATE TABLE IF NOT EXISTS `categoria` (
  `ct_id` int(11) NOT NULL AUTO_INCREMENT,
  `ct_nome` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ct_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Copiando dados para a tabela arquivovivomv.categoria: ~12 rows (aproximadamente)
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` (`ct_id`, `ct_nome`) VALUES
	(2, 'AMBIENTES'),
	(3, 'APARADOR'),
	(4, 'CADEIRAS'),
	(5, 'CREDENZA'),
	(6, 'ESCRIVANINHA'),
	(7, 'ESTANTE'),
	(8, 'MESA LATERAL'),
	(9, 'MESA ALTA'),
	(10, 'MESA DE CENTRO'),
	(11, 'OBJETOS'),
	(12, 'POLTRONAS'),
	(13, 'SOFÁS');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

-- Copiando estrutura para tabela arquivovivomv.moveis
CREATE TABLE IF NOT EXISTS `moveis` (
  `m_id` int(11) NOT NULL AUTO_INCREMENT,
  `m_imagem` mediumblob,
  `m_desc` varchar(250) DEFAULT NULL,
  `m_qtdEstoque` int(7) DEFAULT NULL,
  `m_valUni` double DEFAULT NULL,
  `m_titulo` varchar(150) DEFAULT NULL,
  `m_assoc` varchar(50) DEFAULT NULL,
  `m_designers` varchar(200) DEFAULT NULL,
  `m_dtReg` datetime DEFAULT NULL,
  `f_id` int(11) DEFAULT NULL,
  `m_typeImg` varchar(10) DEFAULT NULL,
  `d_id` int(11) DEFAULT NULL,
  `ct_id` int(3) DEFAULT NULL,
  PRIMARY KEY (`m_id`),
  KEY `fk_designer` (`d_id`),
  KEY `fk_funcionario` (`f_id`),
  KEY `fk_categoria` (`ct_id`),
  CONSTRAINT `fk_categoria` FOREIGN KEY (`ct_id`) REFERENCES `categoria` (`ct_id`),
  CONSTRAINT `fk_designer` FOREIGN KEY (`d_id`) REFERENCES `designers` (`d_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_funcionario` FOREIGN KEY (`f_id`) REFERENCES `funcionarios` (`f_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- Copiando estrutura para tabela arquivovivomv.curtidos
CREATE TABLE IF NOT EXISTS `curtidos` (
  `l_id` int(11) NOT NULL AUTO_INCREMENT,
  `c_id` int(11) DEFAULT NULL,
  `m_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`l_id`),
  KEY `fk_movel` (`m_id`),
  KEY `fk_cliente` (`c_id`),
  CONSTRAINT `fk_cliente` FOREIGN KEY (`c_id`) REFERENCES `cliente` (`c_id`),
  CONSTRAINT `fk_movel` FOREIGN KEY (`m_id`) REFERENCES `moveis` (`m_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Copiando estrutura para tabela arquivovivomv.pedidos
CREATE TABLE IF NOT EXISTS `pedidos` (
  `p_id` int(11) NOT NULL AUTO_INCREMENT,
  `p_nPedido` varchar(50) DEFAULT NULL,
  `p_qtd` int(7) DEFAULT NULL,
  `p_movel` varchar(200) DEFAULT NULL,
  `p_tipos` varchar(20) DEFAULT NULL,
  `p_ordem` varchar(500) DEFAULT NULL,
  `p_preco` double DEFAULT NULL,
  `p_dtReg` datetime DEFAULT NULL,
  `p_state` enum('encerrado','pendente','cancelado') DEFAULT NULL,
  `f_id` int(11) DEFAULT NULL,
  `c_id` int(11) DEFAULT NULL,
  `m_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_movelPedido` (`m_id`),
  KEY `fk_funcionarioPedido` (`f_id`),
  KEY `fk_clientePedido` (`c_id`),
  CONSTRAINT `fk_clientePedido` FOREIGN KEY (`c_id`) REFERENCES `cliente` (`c_id`),
  CONSTRAINT `fk_funcionarioPedido` FOREIGN KEY (`f_id`) REFERENCES `funcionarios` (`f_id`),
  CONSTRAINT `fk_movelPedido` FOREIGN KEY (`m_id`) REFERENCES `moveis` (`m_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

```
:warning: O usuário, senha e servidor nas conexões do programa são, respectivamente `root`, ` ` e `localhost`. <br>
:warning: ***O programa está atrelado ao website desenvolvido em PHP no link:*** <a href="https://github.com/Guilherme-Maciel/ArquivoVivo-Website">ARQUIVO VIVO ONLINE - WEBSITE</a>, ***visite e saiba mais.***

## Compilação
1. Inicie seu servidor local;
2. Abra a solução do projeto e clique em `Iniciar` para realizar a compilação do programa.
