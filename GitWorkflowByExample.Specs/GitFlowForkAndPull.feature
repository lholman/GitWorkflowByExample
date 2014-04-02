Feature: GitFlow ForkAndPull
	In order to make changes to a software product
	As a technical resource
	I want my code changes integrated in to the software product

	Scenario: Stage changes locally
		Given I have an upstream repository "lloydstone/femah"
			And I have a fork of the upstream repository "lholman/femah"
			And I have a local clone of the fork
			And I have a new local branch "how-to-gitflow-fork-and-pull"
		When I make a code change and commit
		Then the local branch is ahead of the fork "lholman/femah" by one commit

	Scenario: Push changes to fork
		Given I have an upstream repository "lloydstone/femah"
			And I have a fork of the upstream repository "lholman/femah"
			And I have a local clone of the fork
			And I have a local branch "how-to-gitflow-fork-and-pull" one commit ahead of the fork "lholman/femah"
		When I push the commit to the fork "lholman/femah"
		Then the fork "lholman/femah" is in sync with the local branch "how-to-gitflow-fork-and-pull"
			And the fork "lholman/femah" is one commit ahead of the upstream repository "lloydstone/femah"