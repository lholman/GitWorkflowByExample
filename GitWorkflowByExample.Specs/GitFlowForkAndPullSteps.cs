using System;
using Octokit;
using TechTalk.SpecFlow;

namespace GitWorkflowByExample.Specs
{
    [Binding]
    public class GitFlowForkAndPullSteps
    {
        [Given(@"I have an upstream repository ""(.*)""")]
        public void GivenIHaveAnUpstreamRepository(string p0)
        {
            //ScenarioContext.Current.Pending();
            //var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
            var repoClient = new RepositoriesClient(new ApiConnection(new Connection(new ProductHeaderValue("femah"))));
            //var user = await github.User.Get("lholman");
            var repo = repoClient.Get("lholman", "Lloyd Holman");
            //Console.WriteLine(user.Followers + " folks love the half ogre!");
        }
        
        [Given(@"I have a fork of the upstream repository ""(.*)""")]
        public void GivenIHaveAForkOfTheUpstreamRepository(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a local clone of the fork")]
        public void GivenIHaveALocalCloneOfTheFork()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a new local branch ""(.*)""")]
        public void GivenIHaveANewLocalBranch(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I make a code change and commit")]
        public void WhenIMakeACodeChangeAndCommit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the local branch is ahead of the fork ""(.*)"" by one commit")]
        public void ThenTheLocalBranchIsAheadOfTheForkByOneCommit(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a local branch ""(.*)"" one commit ahead of the fork ""(.*)""")]
        public void GivenIHaveALocalBranchOneCommitAheadOfTheFork(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I push the commit to the fork ""(.*)""")]
        public void WhenIPushTheCommitToTheFork(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the fork ""(.*)"" is in sync with the local branch ""(.*)""")]
        public void ThenTheForkIsInSyncWithTheLocalBranch(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the fork ""(.*)"" is one commit ahead of the upstream repository ""(.*)""")]
        public void ThenTheForkIsOneCommitAheadOfTheUpstreamRepository(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
