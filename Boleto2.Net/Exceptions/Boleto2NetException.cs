﻿using System;

namespace Boleto2Net.Exceptions
{
    public sealed class Boleto2NetException : Exception
    {
        private Boleto2NetException(string message)
            : base(message)
        {

        }

        private Boleto2NetException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public static Boleto2NetException BancoNaoImplementado(int codigoBanco)
            => new Boleto2NetException($"Banco não implementando: {codigoBanco}");

        public static Boleto2NetException ErroAoFormatarCedente(Exception ex)
            => new Boleto2NetException("Erro durante a formatação do cedente.", ex);

        public static Boleto2NetException ErroAoFormatarCodigoDeBarra(Exception ex)
            => new Boleto2NetException("Erro durante a formatação do código de barra.", ex);

        public static Exception ErroAoFormatarNossoNumero(Exception ex)
            => new Boleto2NetException("Erro durante a formatação do nosso número.", ex);

        public static Exception ErroAoValidarBoleto(Exception ex)
            => new Boleto2NetException("Erro durante a validação do boleto.", ex);

        public static Exception ErroAoGerarRegistroHeaderDoArquivoRemessa(Exception ex)
            => new Boleto2NetException("Erro durante a geração do registro HEADER do arquivo de REMESSA.", ex);

        public static Exception ErroAoGerarRegistroDetalheDoArquivoRemessa(Exception ex)
            => new Boleto2NetException("Erro durante a geração dos registros de DETALHE do arquivo de REMESSA.", ex);

        public static Exception ErroAoGerrarRegistroTrailerDoArquivoRemessa(Exception ex)
            => new Boleto2NetException("Erro durante a geração do registro TRAILER do arquivo de REMESSA.", ex);

    }
}
