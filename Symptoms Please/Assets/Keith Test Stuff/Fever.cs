﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Fever.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Fever: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("sy", () => this.@sy, val => this.@sy = val);
		}

		public StoryVar @sy;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@Fever()
	{
		this.StartPassage = "Untitled Passage";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Untitled Passage

	void passage1_Init()
	{
		this.Passages[@"Untitled Passage"] = new StoryPassage(@"Untitled Passage", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("I have a fever, weight loss, loss of appetite, night sweats, coughing, chills and chest pain. (TB).");
		yield return lineBreak();
		Vars.sy  = macros1.a("nausea", "vomiting", "loss_of_appetite", "night_sweats", "irritability", "abdominal_pain", "headaches");
		yield return lineBreak();
		yield return link("Do you have a fever?", "Do you have a fever?", null);
		yield break;
	}


	// .............
	// #2: Do you have a fever?

	void passage2_Init()
	{
		this.Passages[@"Do you have a fever?"] = new StoryPassage(@"Do you have a fever?", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("asd");
		yield return lineBreak();
		yield return link("You experiencing any nausea?", "Nausea", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #3: Nausea

	void passage3_Init()
	{
		this.Passages[@"Nausea"] = new StoryPassage(@"Nausea", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		if(Vars.sy .Contains("fever")) {
			yield return lineBreak();
			yield return text("	");
			if(Vars.sy .Contains("nausea")) {
				yield return lineBreak();
				yield return text("		");
				yield return link("you experiencing loss of appetite?", "Appetite", null);
				yield return text("	");
				yield return lineBreak();
				yield return text("	");
			}
			else {
				yield return lineBreak();
				yield return text("		");
				yield return link("have you been experiencing phlegm", "Phlegm", null);
				yield return lineBreak();
				yield return text("	");
			}
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("	");
			if(Vars.sy .Contains("nausea")) {
				yield return lineBreak();
				yield return text("		");
				yield return link("Have you been getting headaches?", "Headaches", null);
				yield return lineBreak();
				yield return text("	");
			}
			else {
				yield return lineBreak();
				yield return text("		");
				yield return link("Have you been short of breath?", "Short of breath", null);
				yield return lineBreak();
				yield return text("	");
			}
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #4: Appetite

	void passage4_Init()
	{
		this.Passages[@"Appetite"] = new StoryPassage(@"Appetite", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("asd");
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.sy .Contains(v("all").AsMemberOf[macros1.a("fever","nausea","loss_of_appetite")])) {
			yield return lineBreak();
			yield return text("	You have hepatitus A");
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("	You have pneumonia");
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #5: Phlegm

	void passage5_Init()
	{
		this.Passages[@"Phlegm"] = new StoryPassage(@"Phlegm", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		if(Vars.sy .Contains(v("all").AsMemberOf[macros1.a("fever","nausea","phlegm")])) {
			yield return lineBreak();
			yield return text("	You have the flu");
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("	You have the TB");
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #6: Headaches

	void passage6_Init()
	{
		this.Passages[@"Headaches"] = new StoryPassage(@"Headaches", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("asd");
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.sy .Contains(v("all").AsMemberOf[macros1.a("nausea","headaches")])) {
			yield return lineBreak();
			yield return text("	you have codein");
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("	you have stress");
			yield return lineBreak();
		}
		yield break;
	}


	// .............
	// #7: Short of breath

	void passage7_Init()
	{
		this.Passages[@"Short of breath"] = new StoryPassage(@"Short of breath", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		if(Vars.sy .Contains(macros1.a("short_of_breath"))) {
			yield return lineBreak();
			yield return text("	you have hypertension");
			yield return lineBreak();
		}
		else {
			yield return lineBreak();
			yield return text("	you have diabetes");
			yield return lineBreak();
		}
		yield break;
	}


}