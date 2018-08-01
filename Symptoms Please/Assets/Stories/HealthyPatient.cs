﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: HealthyPatient.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @HealthyPatient: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("sy", () => this.@sy, val => this.@sy = val);
			VarDef("passage", () => this.@passage, val => this.@passage = val);
			VarDef("illness", () => this.@illness, val => this.@illness = val);
			VarDef("spassage", () => this.@spassage, val => this.@spassage = val);
			VarDef("ready", () => this.@ready, val => this.@ready = val);
		}

		public StoryVar @sy;
		public StoryVar @passage;
		public StoryVar @illness;
		public StoryVar @spassage;
		public StoryVar @ready;
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

	@HealthyPatient()
	{
		this.StartPassage = "Intro";

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
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Illness

	void passage1_Init()
	{
		this.Passages[@"Illness"] = new StoryPassage(@"Illness", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Okay, what do you want to know?");
		
		Vars.sy  = macros1.a("none");
		
		yield return link("Have you had a fever?\n", "Fever", null);
		
		Vars.passage  = "Illness";
		
		Vars.illness  = "Illness";
		
		yield return link("Let us talk some more about your life\n", Vars.spassage, null);
		yield break;
	}


	// .............
	// #2: Fever

	void passage2_Init()
	{
		this.Passages[@"Fever"] = new StoryPassage(@"Fever", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		if(Vars.sy .Contains("fever")) {
			
			yield return text ("Yes, I've been feeling hot but also cold at the same time. Sometimes I sweat when it is cold.\n");
			
		}
		else {
			
			yield return text ("I haven't been having a fever. All fine in that department.\n");
			
		}
		
		
		yield return link("Have you been experiencing nausea?\n", "Nausea", null);
		
		Vars.passage  = "Fever";
		
		yield return link("Let us talk some more about your life\n", Vars.spassage, null);
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
			
			
			if(Vars.sy .Contains("nausea")) {
				
				yield return text ("Yes, I have had such a bad feeling whenever I sit down or stand up.\n");
				
				
				yield return link("Have you lost your appetite?\n", "Appetite", null);
				
				
				
			}
			else {
				
				yield return text ("No issues here. I was last nauseas when I had a stomach bug a while back.\n");
				
				
				yield return link("Do you have any phlegm in your throat or chest?\n", "Phlegm", null);
				
				
			}
			
		}
		else {
			
			
			if(Vars.sy .Contains("nausea")) {
				
				yield return text ("Yes, I have had such a bad feeling whenever I sit down or stand up.\n");
				
				
				yield return link("Have you been getting headaches?\n", "Headaches", null);
				
				
			}
			else {
				
				yield return text ("No problems here.");
				
				
				yield return link("Have you been struggling to breath or been breathing heavily?\n", "Short of breath", null);
				
				
			}
			
		}
		
		Vars.passage  = "Nausea";
		
		yield return link("Let us talk some more about your work and life\n", Vars.spassage, null);
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
		if (Vars.sy.Contains ("fever") && Vars.sy.Contains ("nausea") && Vars.sy.Contains ("loss_of_appetite")) {
			
			yield return text ("Yes, I haven't felt hungry recently but it's saving me money.\n");
			
			yield return text ("You have hepatitus A");
			
		}
		else {
			
			yield return text ("If anything, I'm hungrier than usual.\n");
			
			yield return text ("You have pneumonia");
			
		}
		
		yield return link("I am ready to make a diagnosis\n", "Diagnose", null);
		
		Vars.passage  = "Appetite";
		
		yield return link("Let us talk some more about your life\n", Vars.spassage, null);
		
		Vars.ready  = "yes";
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
		if (Vars.sy.Contains ("fever") && Vars.sy.Contains ("nausea") && Vars.sy.Contains ("phlegm")) {
			
			yield return text ("Yes and it comes up when I cough. It's especially bad when I wake up.\n");
			
			yield return text ("You have the flu\n");
			
		}
		else {
			
			yield return text ("No my throat is very clear and I don't feel any phlegm\n");
			
			
			
		}
		
		yield return link("I am ready to make a diagnosis\n", "Diagnose", null);
		
		Vars.passage  = "Phlegm";
		
		yield return link("Let us talk some more about your work and life\n", Vars.spassage, null);
		
		Vars.ready  = "yes";
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
		if (Vars.sy.Contains ("nausea") && Vars.sy.Contains ("headaches")) {
			
			yield return text ("Yes very sore headaches!\n");
			
			yield return text ("you have codein\n");
			
		}
		else {
			
			yield return text ("No, I haven't been getting any headaches.\n");
			
			yield return text ("you have stress\n");
			
		}
		
		yield return link("I am ready to make a diagnosis\n", "Diagnose", null);
		
		Vars.passage  = "Headaches";
		
		yield return link("Let us talk some more about your work and life\n", Vars.spassage, null);
		
		Vars.ready  = "yes";
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
			
			yield return text ("Yes, I often struggle to catch my breath and start feeling short of breath even when I don't exercise.\n");
			
			yield return text ("you have hypertension");
			
		}
		else {
			
			yield return text ("No. I do feel it when I go up stairs but that is normal for me. I need to work on my cardio at gym.\n");
			
			yield return text ("you have diabetes");
			
		}
		
		yield return link("I am ready to make a diagnosis\n", "Diagnose", null);
		
		Vars.passage  = "Short of breath";
		
		yield return link("Let us talk some more about your work and life\n", Vars.spassage, null);
		
		Vars.ready  = "yes";
		yield break;
	}


	// .............
	// #8: Intro

	void passage8_Init()
	{
		this.Passages[@"Intro"] = new StoryPassage(@"Intro", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("Patient: \"I'm just here for a regular check-up.\"");
		yield return lineBreak ();
		
		yield return text("Dr: \"Well let's have a look at you.\"");
		yield return lineBreak ();

		Vars.passage  = "Illness";
		
		Vars.spassage  = "Intro";
		
		Vars.ready  = "no";
		
		yield return link("have you lost weight recently?\n", "Weight loss story", null);
		
		yield return link("have you been feeling unusually tired?\n", "Fatigue story", null);
		
		yield return link("Have you been feeling hungry?\n", "Hunger story", null);
		
		yield return link("How have your relationships with friends and family been?\n", "Irritability story", null);
		
		yield return link("Notice anything abnormal about your body?\n", "Illness", null);
		yield break;
	}


	// .............
	// #9: Family History

	void passage9_Init()
	{
		this.Passages[@"Family History"] = new StoryPassage(@"Family History", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("My mom died of cancer and my uncle has depression but that's about it.\n");
		
		Vars.spassage  = "Family History";
		
		if(Vars.ready == "no") {
			
			
			yield return link("I'm the doctor here. Let me check you for symptoms\n", Vars.passage, null);
			
		}
		else {
			
			yield return link("I think that I am ready to make a diagnosis\n", "Diagnose", null);
			
		}
		
		yield break;
	}


	// .............
	// #10: Weight loss story

	void passage10_Init()
	{
		this.Passages[@"Weight loss story"] = new StoryPassage(@"Weight loss story", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("Only a bit but that's a good thing. I've been exercising.\n");
		
		Vars.spassage  = "Weight loss story";
		
		yield return link("Does your family have a history of illness?\n", "Family History", null);
		
		yield return link("I'm the doctor here. Let me check you for symptoms\n", Vars.passage, null);
		yield break;
	}


	// .............
	// #11: Fatigue story

	void passage11_Init()
	{
		this.Passages[@"Fatigue story"] = new StoryPassage(@"Fatigue story", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("No fatigue at all, doc.");
		
		Vars.spassage  = "Fatigue story";
		
		yield return link("Does your family have any history of illness?\n", "Family History", null);
		
		yield return link("I'm the doctor here. Let me check you for symptoms\n", Vars.passage, null);
		yield break;
	}


	// .............
	// #12: Hunger story

	void passage12_Init()
	{
		this.Passages[@"Hunger story"] = new StoryPassage(@"Hunger story", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("A lot of hunger but that's part of my new exercise routine. I hit the gym about once a day.\n");
		
		Vars.spassage  = "Hunger story";
		
		yield return link("Does your family have a history of illness?\n", "Family History", null);
		
		yield return link("I'm the doctor here. Let me check you for symptoms\n", Vars.passage, null);
		yield break;
	}


	// .............
	// #13: Irritability story

	void passage13_Init()
	{
		this.Passages[@"Irritability story"] = new StoryPassage(@"Irritability story", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("I have anger managment issues but not much else. Just a bit of roadrage. Listening to podcasts on the way to work seems to help.\n");
		
		Vars.spassage  = "Irritability story";
		
		yield return link("Does your family have a history of illness\n", "Family History", null);
		
		yield return link("I'm the doctor here. Let me check you for symptoms\n", Vars.passage, null);
		yield break;
	}


	// .............
	// #14: Diagnose

	void passage14_Init()
	{
		this.Passages[@"Diagnose"] = new StoryPassage(@"Diagnose", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield break;
	}


}