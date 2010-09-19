// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Hosted
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Automatic Progression")]
    public partial class AutomaticProgressionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AutomaticProgression.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Automatic Progression", "In order to speed up gameplay\r\nAs a dominion player\r\nI want the game state to adv" +
                    "ance automatically when there are no possible actions", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Immediately move to buy step when no actions")]
        public virtual void ImmediatelyMoveToBuyStepWhenNoActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Immediately move to buy step when no actions", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("A new hosted game with 3 players");
#line 8
testRunner.When("The game begins");
#line 9
testRunner.Then("Player1 should be in the buy step");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Allow player to play actions")]
        public virtual void AllowPlayerToPlayActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allow player to play actions", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
testRunner.Given("A new hosted game with 3 players");
#line 13
testRunner.And("Player1 has a Smithy in hand instead of a Copper");
#line 14
testRunner.When("The game begins");
#line 15
testRunner.Then("Player1 should have 1 remaining action");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Automatic progression when previous player uses their buys and current player has" +
            " no actions")]
        public virtual void AutomaticProgressionWhenPreviousPlayerUsesTheirBuysAndCurrentPlayerHasNoActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Automatic progression when previous player uses their buys and current player has" +
                    " no actions", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
testRunner.Given("A new hosted game with 3 players");
#line 19
testRunner.When("The game begins");
#line 20
testRunner.And("Player1 tells the host to buy Copper");
#line 21
testRunner.Then("Player2 should be in the buy step");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Automatic progression when using 1 of 2 buys")]
        public virtual void AutomaticProgressionWhenUsing1Of2Buys()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Automatic progression when using 1 of 2 buys", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
testRunner.Given("A new hosted game with 3 players");
#line 25
testRunner.And("Player1 has a Woodcutter in hand instead of a Copper");
#line 26
testRunner.When("The game begins");
#line 27
testRunner.And("Player1 tells the host to play Woodcutter");
#line 28
testRunner.And("Player1 tells the host to buy Copper");
#line 29
testRunner.Then("Player1 should be in the buy step");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Automatic progression when using 2 of 2 buys")]
        public virtual void AutomaticProgressionWhenUsing2Of2Buys()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Automatic progression when using 2 of 2 buys", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
testRunner.Given("A new hosted game with 3 players");
#line 33
testRunner.And("Player1 has a Woodcutter in hand instead of a Copper");
#line 34
testRunner.When("The game begins");
#line 35
testRunner.And("Player1 tells the host to play Woodcutter");
#line 36
testRunner.And("Player1 tells the host to buy Copper");
#line 37
testRunner.And("Player1 tells the host to buy Copper");
#line 38
testRunner.Then("Player2 should be in the buy step");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Automatic progression at the game end")]
        public virtual void AutomaticProgressionAtTheGameEnd()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Automatic progression at the game end", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
testRunner.Given("A new hosted game with 3 players");
#line 42
testRunner.But("There is only 1 Province left");
#line 43
testRunner.And("Player1 has a hand of all Gold");
#line 44
testRunner.When("The game begins");
#line 45
testRunner.And("Player1 tells the host to buy Province");
#line 46
testRunner.Then("The game should have ended");
#line 47
testRunner.And("Player1 should be the winner");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Automatic progression when an effect is in progress")]
        public virtual void AutomaticProgressionWhenAnEffectIsInProgress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Automatic progression when an effect is in progress", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
testRunner.Given("A new hosted game with 3 players");
#line 51
testRunner.And("Player1 has a Militia in hand instead of a Copper");
#line 52
testRunner.When("The game begins");
#line 53
testRunner.And("Player1 tells the host to play Militia");
#line 54
testRunner.Then("Player1 should be in the action step");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
