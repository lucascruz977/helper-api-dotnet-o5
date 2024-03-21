using helper_api_dotnet_o5.Models.Paises;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

public class ConsultaCPNJOutPut
{
    public ConsultaCPNJOutPut()
    {
        this.Bairro = string.Empty;
        this.CapitalSocial = 0;
        this.Cep = string.Empty;
        this.CnaeFiscal = 0;
        this.CnaeFiscalDescricao = string.Empty;
        this.CnaesSecundarios = new List<CnaeSecundario>();
        this.Cnpj = string.Empty;
        this.CodigoMunicipio = 0;
        this.CodigoMunicipioIbge = 0;
        this.CodigoNaturezaJuridica = 0;
        this.CodigoPais = new object();
        this.CodigoPorte = 0;
        this.Complemento = string.Empty;
        this.DataExclusaoDoMei = new object();
        this.DataExclusaoDoSimples = new object();
        this.DataInicioAtividade = new DateTime();
        this.DataOpcaoPeloMei = new object();
        this.DataOpcaoPeloSimples = new object();
        this.DataSituacaoCadastral = new DateTime();
        this.DataSituacaoEspecial = new object();
        this.DddFax = string.Empty;
        this.DddTelefone1 = string.Empty;
        this.DddTelefone2 = string.Empty;
        this.DescricaoIdentificadorMatrizFilial = string.Empty;
        this.DescricaoMotivoSituacaoCadastral = string.Empty;
        this.DescricaoPorte = string.Empty;
        this.DescricaoSituacaoCadastral = string.Empty;
        this.DescricaoTipoDeLogradouro = string.Empty;
        this.Email = new object();
        this.EnteFederativoResponsavel = string.Empty;
        this.IdentificadorMatrizFilial = 0;
        this.Logradouro = string.Empty;
        this.MotivoSituacaoCadastral = 0;
        this.Municipio = string.Empty;
        this.NaturezaJuridica = string.Empty;
        this.NomeCidadeNoExterior = string.Empty;
        this.NomeFantasia = string.Empty;
        this.Numero = string.Empty;
        this.OpcaoPeloMei = new object();
        this.OpcaoPeloSimples = new object();
        this.Pais = new object();
        this.Porte =string.Empty;
        this.Qsa = new List<Qsa>();
        this.QualificacaoDoResponsavel = 0;
        this.RazaoSocial = string.Empty;
        this.SituacaoCadastral = 0;
        this.SituacaoEspecial = string.Empty;
        this.Uf = string.Empty;
    }

    [JsonProperty("bairro")]
    public string Bairro { get; set; }

    [JsonProperty("capital_social")]
    public long CapitalSocial { get; set; }

    [JsonProperty("cep")]
    public string Cep { get; set; }

    [JsonProperty("cnae_fiscal")]
    public long CnaeFiscal { get; set; }

    [JsonProperty("cnae_fiscal_descricao")]
    public string CnaeFiscalDescricao { get; set; }

    [JsonProperty("cnaes_secundarios")]
    public List<CnaeSecundario> CnaesSecundarios { get; set; }

    [JsonProperty("cnpj")]
    public string Cnpj { get; set; }

    [JsonProperty("codigo_municipio")]
    public int CodigoMunicipio { get; set; }

    [JsonProperty("codigo_municipio_ibge")]
    public int CodigoMunicipioIbge { get; set; }

    [JsonProperty("codigo_natureza_juridica")]
    public int CodigoNaturezaJuridica { get; set; }

    [JsonProperty("codigo_pais")]
    public object CodigoPais { get; set; }

    [JsonProperty("codigo_porte")]
    public int CodigoPorte { get; set; }

    [JsonProperty("complemento")]
    public string Complemento { get; set; }

    [JsonProperty("data_exclusao_do_mei")]
    public object DataExclusaoDoMei { get; set; }

    [JsonProperty("data_exclusao_do_simples")]
    public object DataExclusaoDoSimples { get; set; }

    [JsonProperty("data_inicio_atividade")]
    public DateTime DataInicioAtividade { get; set; }

    [JsonProperty("data_opcao_pelo_mei")]
    public object DataOpcaoPeloMei { get; set; }

    [JsonProperty("data_opcao_pelo_simples")]
    public object DataOpcaoPeloSimples { get; set; }

    [JsonProperty("data_situacao_cadastral")]
    public DateTime DataSituacaoCadastral { get; set; }

    [JsonProperty("data_situacao_especial")]
    public object DataSituacaoEspecial { get; set; }

    [JsonProperty("ddd_fax")]
    public string DddFax { get; set; }

    [JsonProperty("ddd_telefone_1")]
    public string DddTelefone1 { get; set; }

    [JsonProperty("ddd_telefone_2")]
    public string DddTelefone2 { get; set; }

    [JsonProperty("descricao_identificador_matriz_filial")]
    public string DescricaoIdentificadorMatrizFilial { get; set; }

    [JsonProperty("descricao_motivo_situacao_cadastral")]
    public string DescricaoMotivoSituacaoCadastral { get; set; }

    [JsonProperty("descricao_porte")]
    public string DescricaoPorte { get; set; }

    [JsonProperty("descricao_situacao_cadastral")]
    public string DescricaoSituacaoCadastral { get; set; }

    [JsonProperty("descricao_tipo_de_logradouro")]
    public string DescricaoTipoDeLogradouro { get; set; }

    [JsonProperty("email")]
    public object Email { get; set; }

    [JsonProperty("ente_federativo_responsavel")]
    public string EnteFederativoResponsavel { get; set; }

    [JsonProperty("identificador_matriz_filial")]
    public int IdentificadorMatrizFilial { get; set; }

    [JsonProperty("logradouro")]
    public string Logradouro { get; set; }

    [JsonProperty("motivo_situacao_cadastral")]
    public int MotivoSituacaoCadastral { get; set; }

    [JsonProperty("municipio")]
    public string Municipio { get; set; }

    [JsonProperty("natureza_juridica")]
    public string NaturezaJuridica { get; set; }

    [JsonProperty("nome_cidade_no_exterior")]
    public string NomeCidadeNoExterior { get; set; }

    [JsonProperty("nome_fantasia")]
    public string NomeFantasia { get; set; }

    [JsonProperty("numero")]
    public string Numero { get; set; }

    [JsonProperty("opcao_pelo_mei")]
    public object OpcaoPeloMei { get; set; }

    [JsonProperty("opcao_pelo_simples")]
    public object OpcaoPeloSimples { get; set; }

    [JsonProperty("pais")]
    public object Pais { get; set; }

    [JsonProperty("porte")]
    public string Porte { get; set; }

    [JsonProperty("qsa")]
    public List<Qsa> Qsa { get; set; }

    [JsonProperty("qualificacao_do_responsavel")]
    public int QualificacaoDoResponsavel { get; set; }

    [JsonProperty("razao_social")]
    public string RazaoSocial { get; set; }

    [JsonProperty("situacao_cadastral")]
    public int SituacaoCadastral { get; set; }

    [JsonProperty("situacao_especial")]
    public string SituacaoEspecial { get; set; }

    [JsonProperty("uf")]
    public string Uf { get; set; }
}

public class CnaeSecundario
{
    [JsonProperty("codigo")]
    public int Codigo { get; set; }

    [JsonProperty("descricao")]
    public string Descricao { get; set; }
}

public class Qsa
{
    [JsonProperty("cnpj_cpf_do_socio")]
    public string CnpjCpfDoSocio { get; set; }

    [JsonProperty("codigo_faixa_etaria")]
    public int CodigoFaixaEtaria { get; set; }

    [JsonProperty("codigo_pais")]
    public object CodigoPais { get; set; }

    [JsonProperty("codigo_qualificacao_representante_legal")]
    public int CodigoQualificacaoRepresentanteLegal { get; set; }

    [JsonProperty("codigo_qualificacao_socio")]
    public int CodigoQualificacaoSocio { get; set; }

    [JsonProperty("cpf_representante_legal")]
    public string CpfRepresentanteLegal { get; set; }

    [JsonProperty("data_entrada_sociedade")]
    public DateTime DataEntradaSociedade { get; set; }

    [JsonProperty("faixa_etaria")]
    public string FaixaEtaria { get; set; }

    [JsonProperty("identificador_de_socio")]
    public int IdentificadorDeSocio { get; set; }

    [JsonProperty("nome_representante_legal")]
    public string NomeRepresentanteLegal { get; set; }

    [JsonProperty("nome_socio")]
    public string NomeSocio { get; set; }
    [JsonProperty("pais")]
    public object Pais { get; set; }
    [JsonProperty("qualificacao_representante_legal")]
    public string QualificacaoRepresentanteLegal { get; set; }
    [JsonProperty("qualificacao_socio")]
    public string QualificacaoSocio { get; set; }
}
