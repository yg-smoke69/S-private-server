using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E8")]
public class ObjectSelector : MonoBehaviour
{
	[Token(Token = "0x20007E9")]
	public enum SelectorType
	{
		[Token(Token = "0x4005006")]
		ByMasterRank
	}

	[Serializable]
	[Token(Token = "0x20007EA")]
	public class SelectionRule
	{
		[Token(Token = "0x4005007")]
		[FieldOffset(Offset = "0x8")]
		public int threshold;

		[Token(Token = "0x4005008")]
		[FieldOffset(Offset = "0xC")]
		public GameObject selectedObject;

		[Token(Token = "0x600320D")]
		[Address(RVA = "0x1C74AA8", Offset = "0x1C74AA8", VA = "0x1C74AA8")]
		public SelectionRule()
		{
		}
	}

	[Token(Token = "0x4005002")]
	[FieldOffset(Offset = "0xC")]
	private ParticleSystem activeParticle;

	[Token(Token = "0x4005003")]
	[FieldOffset(Offset = "0x10")]
	public SelectorType SelectType;

	[Token(Token = "0x4005004")]
	[FieldOffset(Offset = "0x14")]
	public List<SelectionRule> Rules;

	[Token(Token = "0x600320A")]
	[Address(RVA = "0x1C74134", Offset = "0x1C74134", VA = "0x1C74134")]
	public ObjectSelector()
	{
	}

	[Token(Token = "0x600320B")]
	[Address(RVA = "0x1C741C0", Offset = "0x1C741C0", VA = "0x1C741C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600320C")]
	[Address(RVA = "0x1C74994", Offset = "0x1C74994", VA = "0x1C74994")]
	private void Update()
	{
	}
}
