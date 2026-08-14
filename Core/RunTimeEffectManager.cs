using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001DD5")]
public class RunTimeEffectManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2001DD6")]
	public struct EffectElement
	{
		[Token(Token = "0x400BCEE")]
		[FieldOffset(Offset = "0x0")]
		public Transform m_EffectTransForm;

		[Token(Token = "0x400BCEF")]
		[FieldOffset(Offset = "0x4")]
		public string m_TargetRootName;

		[Token(Token = "0x400BCF0")]
		[FieldOffset(Offset = "0x8")]
		public string m_TargetBoneName;

		[Token(Token = "0x400BCF1")]
		[FieldOffset(Offset = "0xC")]
		public bool ScaleWithParent;

		[Token(Token = "0x400BCF2")]
		[FieldOffset(Offset = "0x10")]
		public Transform TargetTransform;
	}

	[Token(Token = "0x400BCED")]
	[FieldOffset(Offset = "0xC")]
	public EffectElement[] m_EffectElements;

	[Token(Token = "0x6008E88")]
	[Address(RVA = "0x316D5C8", Offset = "0x316D5C8", VA = "0x316D5C8")]
	public RunTimeEffectManager()
	{
	}

	[Token(Token = "0x6008E89")]
	[Address(RVA = "0x316D63C", Offset = "0x316D63C", VA = "0x316D63C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008E8A")]
	[Address(RVA = "0x316DAF8", Offset = "0x316DAF8", VA = "0x316DAF8")]
	private bool ScaleInLocalSpace(GameObject o)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E8B")]
	[Address(RVA = "0x316DC48", Offset = "0x316DC48", VA = "0x316DC48")]
	public void InitEffectElements()
	{
	}

	[Token(Token = "0x6008E8C")]
	[Address(RVA = "0x316E004", Offset = "0x316E004", VA = "0x316E004")]
	private Transform FindTransformByName(Transform root, string name)
	{
		return null;
	}

	[Token(Token = "0x6008E8D")]
	[Address(RVA = "0x316E254", Offset = "0x316E254", VA = "0x316E254")]
	public static void ProcessBoneNameRefs(GameObject go, GameObject parentGo)
	{
	}
}
