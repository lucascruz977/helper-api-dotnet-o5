using helper_api_dotnet_o5.Models.Paises;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

public class ConsultaCPNJOutPut
{
    public ConsultaCPNJOutPut()
    {
        this.Bairro2 = string.Empty;
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

    public ConsultaCPNJOutPut(string bairro, int capitalSocial, string cep, long cnaeFiscal, string cnaeFiscalDescricao, List<CnaeSecundario> cnaesSecundarios, string cnpj, int codigoMunicipio, int codigoMunicipioIbge, int codigoNaturezaJuridica, object codigoPais, int codigoPorte, string complemento, object dataExclusaoDoMei, object dataExclusaoDoSimples, DateTime dataInicioAtividade, object dataOpcaoPeloMei, object dataOpcaoPeloSimples, DateTime dataSituacaoCadastral, object dataSituacaoEspecial, string dddFax, string dddTelefone1, string dddTelefone2, string descricaoIdentificadorMatrizFilial, string descricaoMotivoSituacaoCadastral, string descricaoPorte, string descricaoSituacaoCadastral, string descricaoTipoDeLogradouro, object email, string enteFederativoResponsavel, int identificadorMatrizFilial, string logradouro, int motivoSituacaoCadastral, string municipio, string naturezaJuridica, string nomeCidadeNoExterior, string nomeFantasia, string numero, object opcaoPeloMei, object opcaoPeloSimples, object pais, string porte, List<Qsa> qsa, int qualificacaoDoResponsavel, string razaoSocial, int situacaoCadastral, string situacaoEspecial, string uf)
    {
        Bairro2 = bairro ?? throw new ArgumentNullException(nameof(bairro));
        CapitalSocial = capitalSocial;
        Cep = cep ?? throw new ArgumentNullException(nameof(cep));
        CnaeFiscal = cnaeFiscal;
        CnaeFiscalDescricao = cnaeFiscalDescricao ?? throw new ArgumentNullException(nameof(cnaeFiscalDescricao));
        CnaesSecundarios = cnaesSecundarios ?? throw new ArgumentNullException(nameof(cnaesSecundarios));
        Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
        CodigoMunicipio = codigoMunicipio;
        CodigoMunicipioIbge = codigoMunicipioIbge;
        CodigoNaturezaJuridica = codigoNaturezaJuridica;
        CodigoPais = codigoPais ?? throw new ArgumentNullException(nameof(codigoPais));
        CodigoPorte = codigoPorte;
        Complemento = complemento ?? throw new ArgumentNullException(nameof(complemento));
        DataExclusaoDoMei = dataExclusaoDoMei ?? throw new ArgumentNullException(nameof(dataExclusaoDoMei));
        DataExclusaoDoSimples = dataExclusaoDoSimples ?? throw new ArgumentNullException(nameof(dataExclusaoDoSimples));
        DataInicioAtividade = dataInicioAtividade;
        DataOpcaoPeloMei = dataOpcaoPeloMei ?? throw new ArgumentNullException(nameof(dataOpcaoPeloMei));
        DataOpcaoPeloSimples = dataOpcaoPeloSimples ?? throw new ArgumentNullException(nameof(dataOpcaoPeloSimples));
        DataSituacaoCadastral = dataSituacaoCadastral;
        DataSituacaoEspecial = dataSituacaoEspecial ?? throw new ArgumentNullException(nameof(dataSituacaoEspecial));
        DddFax = dddFax ?? throw new ArgumentNullException(nameof(dddFax));
        DddTelefone1 = dddTelefone1 ?? throw new ArgumentNullException(nameof(dddTelefone1));
        DddTelefone2 = dddTelefone2 ?? throw new ArgumentNullException(nameof(dddTelefone2));
        DescricaoIdentificadorMatrizFilial = descricaoIdentificadorMatrizFilial ?? throw new ArgumentNullException(nameof(descricaoIdentificadorMatrizFilial));
        DescricaoMotivoSituacaoCadastral = descricaoMotivoSituacaoCadastral ?? throw new ArgumentNullException(nameof(descricaoMotivoSituacaoCadastral));
        DescricaoPorte = descricaoPorte ?? throw new ArgumentNullException(nameof(descricaoPorte));
        DescricaoSituacaoCadastral = descricaoSituacaoCadastral ?? throw new ArgumentNullException(nameof(descricaoSituacaoCadastral));
        DescricaoTipoDeLogradouro = descricaoTipoDeLogradouro ?? throw new ArgumentNullException(nameof(descricaoTipoDeLogradouro));
        Email = email ?? throw new ArgumentNullException(nameof(email));
        EnteFederativoResponsavel = enteFederativoResponsavel ?? throw new ArgumentNullException(nameof(enteFederativoResponsavel));
        IdentificadorMatrizFilial = identificadorMatrizFilial;
        Logradouro = logradouro ?? throw new ArgumentNullException(nameof(logradouro));
        MotivoSituacaoCadastral = motivoSituacaoCadastral;
        Municipio = municipio ?? throw new ArgumentNullException(nameof(municipio));
        NaturezaJuridica = naturezaJuridica ?? throw new ArgumentNullException(nameof(naturezaJuridica));
        NomeCidadeNoExterior = nomeCidadeNoExterior ?? throw new ArgumentNullException(nameof(nomeCidadeNoExterior));
        NomeFantasia = nomeFantasia ?? throw new ArgumentNullException(nameof(nomeFantasia));
        Numero = numero ?? throw new ArgumentNullException(nameof(numero));
        OpcaoPeloMei = opcaoPeloMei ?? throw new ArgumentNullException(nameof(opcaoPeloMei));
        OpcaoPeloSimples = opcaoPeloSimples ?? throw new ArgumentNullException(nameof(opcaoPeloSimples));
        Pais = pais ?? throw new ArgumentNullException(nameof(pais));
        Porte = porte ?? throw new ArgumentNullException(nameof(porte));
        Qsa = qsa ?? throw new ArgumentNullException(nameof(qsa));
        QualificacaoDoResponsavel = qualificacaoDoResponsavel;
        RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
        SituacaoCadastral = situacaoCadastral;
        SituacaoEspecial = situacaoEspecial ?? throw new ArgumentNullException(nameof(situacaoEspecial));
        Uf = uf ?? throw new ArgumentNullException(nameof(uf));
    }

    [JsonProperty("bairro")]
    public string Bairro2 { get; set; }
    public int CapitalSocial { get; set; }
    public string Cep { get; set; }
    public long CnaeFiscal { get; set; }
    public string CnaeFiscalDescricao { get; set; }
    public List<CnaeSecundario> CnaesSecundarios { get; set; }
    public string Cnpj { get; set; }
    public int CodigoMunicipio { get; set; }
    public int CodigoMunicipioIbge { get; set; }
    public int CodigoNaturezaJuridica { get; set; }
    public object CodigoPais { get; set; }
    public int CodigoPorte { get; set; }
    public string Complemento { get; set; }
    public object DataExclusaoDoMei { get; set; }
    public object DataExclusaoDoSimples { get; set; }
    public DateTime DataInicioAtividade { get; set; }
    public object DataOpcaoPeloMei { get; set; }
    public object DataOpcaoPeloSimples { get; set; }
    public DateTime DataSituacaoCadastral { get; set; }
    public object DataSituacaoEspecial { get; set; }
    public string DddFax { get; set; }
    public string DddTelefone1 { get; set; }
    public string DddTelefone2 { get; set; }
    public string DescricaoIdentificadorMatrizFilial { get; set; }
    public string DescricaoMotivoSituacaoCadastral { get; set; }
    public string DescricaoPorte { get; set; }
    public string DescricaoSituacaoCadastral { get; set; }
    public string DescricaoTipoDeLogradouro { get; set; }
    public object Email { get; set; }
    public string EnteFederativoResponsavel { get; set; }
    public int IdentificadorMatrizFilial { get; set; }
    public string Logradouro { get; set; }
    public int MotivoSituacaoCadastral { get; set; }
    public string Municipio { get; set; }
    public string NaturezaJuridica { get; set; }
    public string NomeCidadeNoExterior { get; set; }
    public string NomeFantasia { get; set; }
    public string Numero { get; set; }
    public object OpcaoPeloMei { get; set; }
    public object OpcaoPeloSimples { get; set; }
    public object Pais { get; set; }
    public string Porte { get; set; }
    public List<Qsa> Qsa { get; set; }
    public int QualificacaoDoResponsavel { get; set; }
    public string RazaoSocial { get; set; }
    public int SituacaoCadastral { get; set; }
    public string SituacaoEspecial { get; set; }
    public string Uf { get; set; }
}

public class CnaeSecundario
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }
}

public class Qsa
{
    public string CnpjCpfDoSocio { get; set; }
    public int CodigoFaixaEtaria { get; set; }
    public object CodigoPais { get; set; }
    public int CodigoQualificacaoRepresentanteLegal { get; set; }
    public int CodigoQualificacaoSocio { get; set; }
    public string CpfRepresentanteLegal { get; set; }
    public DateTime DataEntradaSociedade { get; set; }
    public string FaixaEtaria { get; set; }
    public int IdentificadorDeSocio { get; set; }
    public string NomeRepresentanteLegal { get; set; }
    public string NomeSocio { get; set; }
    public object Pais { get; set; }
    public string QualificacaoRepresentanteLegal { get; set; }
    public string QualificacaoSocio { get; set; }
}
