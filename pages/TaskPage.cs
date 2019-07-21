//using Mark7Core.Steps;
using OpenQA.Selenium;
using System.Linq;
using System.Threading;

namespace mark7.Pages
{
    public class TaskPage
    {
        private readonly IWebDriver _driver;

        public TaskPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement BemVindo()
        {
            return _driver.FindElement(By.CssSelector("#task-board .panel-body h3"));
        }

        // public void Nova(string titulo, string data)
        // {
        //     _driver.FindElement(By.Id("insert-button")).Click();

        //     _driver.FindElement(By.CssSelector("input[name=title]")).SendKeys(titulo);
        //     _driver.FindElement(By.CssSelector("input[name=dueDate]")).SendKeys(data);
        //     _driver.FindElement(By.CssSelector("button[type=submit]")).Click();
        // }

        // public void Nova2(Tarefa tarefa)
        // {
        //     _driver.FindElement(By.Id("insert-button")).Click();

        //     _driver.FindElement(By.CssSelector("input[name=title]")).SendKeys(tarefa.Titulo);
        //     _driver.FindElement(By.CssSelector("input[name=dueDate]")).SendKeys(tarefa.Data);

        //     var campoTags = _driver.FindElement(By.CssSelector(".bootstrap-tagsinput input"));

        //     foreach (var tag in tarefa.Tags)
        //     {
        //         campoTags.SendKeys(tag);
        //         campoTags.SendKeys(Keys.Tab);
        //         Thread.Sleep(500);
        //     }

        //     _driver.FindElement(By.CssSelector("button[type=submit]")).Click();
        // }

        // public IWebElement RetornaRegistro(string titulo)
        // {
        //     var trs = _driver.FindElements(By.CssSelector("table tbody tr"));
        //     var alvo = trs.FirstOrDefault(tr => tr.Text.Contains(titulo));

        //     if (alvo == null)
        //     {
        //         throw new System.ArgumentException("Erro ao buscar a tarefa cadastrada.");
        //     }

        //     return alvo;
        // }

        // public void SolicitaExclusao(string titulo)
        // {
        //     var res = this.RetornaRegistro(titulo);

        //     // Scoping - busca um elemento dentro de outro elemento
        //     res.FindElement(By.Id("delete-button")).Click();
        // }

        // public void ConfirmaExclusao()
        // {
        //     _driver.FindElement(By.CssSelector(".modal-content button[data-bb-handler=success]")).Click();
        // }

        // public string RetornaAlerta()
        // {
        //    return _driver.FindElement(By.CssSelector(".alert-warn div")).Text;
        // }

        // public IWebElement RetornaMensagemBusca()
        // {
        //     return _driver.FindElement(By.CssSelector(".panel-c-warning div"));
        // }

        // public void Voltar()
        // {
        //     _driver.FindElement(By.LinkText("Voltar")).Click();
        // }

        // public void BuscaPorTitulo(string titulo)
        // {
        //     var campoBusca = _driver.FindElement(By.Id("search-input"));
        //     campoBusca.SendKeys(titulo);
        //     //campoBusca.Submit(); // Submete o formulário sem precisar clicar em enviar
        //     _driver.FindElement(By.Id("search-button")).Click();
        // }

        // public int RetornaQuantidadeRegistros()
        // {
        //     var trs = _driver.FindElements(By.CssSelector("table tbody tr"));
        //     return trs.Count;
        // }
    }
}
