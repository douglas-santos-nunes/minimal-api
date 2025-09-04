using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;
using MinimalApi.Infraestrutura.Db;
namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorServicoTest
{
    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        //Arrange
        var adm = new Administrador();
        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        //Act


        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);

    }
}