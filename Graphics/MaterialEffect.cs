using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200078B")]
public class MaterialEffect
{
	[Token(Token = "0x4004E86")]
	[FieldOffset(Offset = "0x0")]
	public static RGBCurve curve;

	[Token(Token = "0x4004E87")]
	[FieldOffset(Offset = "0x8")]
	public ResourceID curveID;

	[Token(Token = "0x4004E88")]
	[FieldOffset(Offset = "0x4")]
	internal static readonly int ColorName;

	[Token(Token = "0x4004E89")]
	[FieldOffset(Offset = "0xC")]
	public float maxTime;

	[Token(Token = "0x4004E8A")]
	[FieldOffset(Offset = "0x10")]
	private List<Material> mats;

	[Token(Token = "0x4004E8B")]
	[FieldOffset(Offset = "0x14")]
	public STimer timer;

	[Token(Token = "0x600306D")]
	[Address(RVA = "0x1C6A600", Offset = "0x1C6A600", VA = "0x1C6A600")]
	public MaterialEffect()
	{
	}

	[Token(Token = "0x600306E")]
	[Address(RVA = "0x1C6A680", Offset = "0x1C6A680", VA = "0x1C6A680")]
	public void Play(List<Material> curMats)
	{
	}

	[Token(Token = "0x600306F")]
	[Address(RVA = "0x1C6ACB0", Offset = "0x1C6ACB0", VA = "0x1C6ACB0")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x6003070")]
	[Address(RVA = "0x1C6A9C8", Offset = "0x1C6A9C8", VA = "0x1C6A9C8")]
	private void SetColor(float time)
	{
	}

	[Token(Token = "0x6003071")]
	[Address(RVA = "0x1C6ACF8", Offset = "0x1C6ACF8", VA = "0x1C6ACF8")]
	public void Stop()
	{
	}

	[Token(Token = "0x6003072")]
	[Address(RVA = "0x1C6AEF0", Offset = "0x1C6AEF0", VA = "0x1C6AEF0")]
	public void Release()
	{
	}
}
