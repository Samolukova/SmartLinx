﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Redirector.Tests.ReturnNotFoundFeature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class КакПользовательЯМогуПопытатьсяОткрытьВБраузереУмнуюСсылкуДляКоторойНеОпределеныПравилаРедиректаИУвидеть404ОшибкуЧтобыПонятьЧтоТакойУмнойСсылкиНеСуществует_Feature : object, Xunit.IClassFixture<КакПользовательЯМогуПопытатьсяОткрытьВБраузереУмнуюСсылкуДляКоторойНеОпределеныПравилаРедиректаИУвидеть404ОшибкуЧтобыПонятьЧтоТакойУмнойСсылкиНеСуществует_Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ReturnsNotFound.feature"
#line hidden
        
        public КакПользовательЯМогуПопытатьсяОткрытьВБраузереУмнуюСсылкуДляКоторойНеОпределеныПравилаРедиректаИУвидеть404ОшибкуЧтобыПонятьЧтоТакойУмнойСсылкиНеСуществует_Feature(КакПользовательЯМогуПопытатьсяОткрытьВБраузереУмнуюСсылкуДляКоторойНеОпределеныПравилаРедиректаИУвидеть404ОшибкуЧтобыПонятьЧтоТакойУмнойСсылкиНеСуществует_Feature.FixtureData fixtureData, Redirector_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "ReturnNotFoundFeature", "Как пользователь, я могу попытаться открыть в браузере умную ссылку, для которой " +
                    "не определены правила редиректа, и увидеть 404 ошибку, чтобы понять, что такой у" +
                    "мной ссылки не существует.", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Приложение отвечает 404 Not Found ошибкой на GET запрос, если для запрашиваемой у" +
            "мной ссылки не определены правила редиректа")]
        [Xunit.TraitAttribute("FeatureTitle", "Как пользователь, я могу попытаться открыть в браузере умную ссылку, для которой " +
            "не определены правила редиректа, и увидеть 404 ошибку, чтобы понять, что такой у" +
            "мной ссылки не существует.")]
        [Xunit.TraitAttribute("Description", "Приложение отвечает 404 Not Found ошибкой на GET запрос, если для запрашиваемой у" +
            "мной ссылки не определены правила редиректа")]
        public void ПриложениеОтвечает404NotFoundОшибкойНаGETЗапросЕслиДляЗапрашиваемойУмнойСсылкиНеОпределеныПравилаРедиректа()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Приложение отвечает 404 Not Found ошибкой на GET запрос, если для запрашиваемой у" +
                    "мной ссылки не определены правила редиректа", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
    testRunner.Given("Для умной ссылки /non-exists не определены правила редиректа", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 6
    testRunner.When("Клиент отправляет GET-запрос на url /non-exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 7
    testRunner.Then("Приложение отвечает 404 Not Found ошибкой", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                КакПользовательЯМогуПопытатьсяОткрытьВБраузереУмнуюСсылкуДляКоторойНеОпределеныПравилаРедиректаИУвидеть404ОшибкуЧтобыПонятьЧтоТакойУмнойСсылкиНеСуществует_Feature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                КакПользовательЯМогуПопытатьсяОткрытьВБраузереУмнуюСсылкуДляКоторойНеОпределеныПравилаРедиректаИУвидеть404ОшибкуЧтобыПонятьЧтоТакойУмнойСсылкиНеСуществует_Feature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion