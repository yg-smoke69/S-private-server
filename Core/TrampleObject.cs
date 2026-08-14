using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079A")]
public class TrampleObject : MetaObject
{
	[Token(Token = "0x4004ECA")]
	[FieldOffset(Offset = "0x14")]
	public bool Enable;

	[Token(Token = "0x4004ECB")]
	[FieldOffset(Offset = "0x18")]
	public uint MeshTemplateID;

	[Token(Token = "0x4004ECC")]
	[FieldOffset(Offset = "0x1C")]
	public uint TriggerTemplateID;

	[NonSerialized]
	[Token(Token = "0x4004ECD")]
	[FieldOffset(Offset = "0x20")]
	private float timeStamp;

	[NonSerialized]
	[Token(Token = "0x4004ECE")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_AudioSource;

	[NonSerialized]
	[Token(Token = "0x4004ECF")]
	[FieldOffset(Offset = "0x28")]
	private List<Material> mats;

	[NonSerialized]
	[Token(Token = "0x4004ED0")]
	[FieldOffset(Offset = "0x2C")]
	private MaterialEffect materialEffect;

	[Token(Token = "0x600309D")]
	[Address(RVA = "0x263AF98", Offset = "0x263AF98", VA = "0x263AF98")]
	public TrampleObject()
	{
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x263B03C", Offset = "0x263B03C", VA = "0x263B03C")]
	public void Init()
	{
	}

	[Token(Token = "0x600309F")]
	[Address(RVA = "0x263B040", Offset = "0x263B040", VA = "0x263B040")]
	private void GenerateShadowMats(GameObject go)
	{
	}

	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x263B228", Offset = "0x263B228", VA = "0x263B228")]
	public void SetStatus(bool enable)
	{
	}

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x263B268", Offset = "0x263B268", VA = "0x263B268")]
	public void PlaySound(ResourceID resourceID)
	{
	}

	[Token(Token = "0x60030A2")]
	[Address(RVA = "0x263B398", Offset = "0x263B398", VA = "0x263B398")]
	public void SetStatus(bool enable, ulong curTimeStamp)
	{
	}

	[Token(Token = "0x60030A3")]
	[Address(RVA = "0x263B498", Offset = "0x263B498", VA = "0x263B498")]
	public void Update()
	{
	}
}
