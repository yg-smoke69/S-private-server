using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2004037")]
public class UVSeqPlayer : MonoBehaviour
{
	[Token(Token = "0x2004038")]
	public enum JNCHOHCCKBF
	{
		[Token(Token = "0x401B032")]
		Normal,
		[Token(Token = "0x401B033")]
		Shuffle
	}

	[Serializable]
	[Token(Token = "0x2004039")]
	public class Interval
	{
		[Token(Token = "0x401B034")]
		[FieldOffset(Offset = "0x8")]
		public int a;

		[Token(Token = "0x401B035")]
		[FieldOffset(Offset = "0xC")]
		public int b;

		[Token(Token = "0x601A274")]
		[Address(RVA = "0x1D51F14", Offset = "0x1D51F14", VA = "0x1D51F14")]
		public Interval(int NHJNFPKBBLI, int LGALHNNDGNE)
		{
		}
	}

	[Token(Token = "0x401B023")]
	[FieldOffset(Offset = "0xC")]
	public int[] columnRow;

	[Token(Token = "0x401B024")]
	[FieldOffset(Offset = "0x10")]
	public float playVelocity;

	[Token(Token = "0x401B025")]
	[FieldOffset(Offset = "0x14")]
	public float startIndex;

	[Token(Token = "0x401B026")]
	[FieldOffset(Offset = "0x18")]
	public bool useInterval;

	[Token(Token = "0x401B027")]
	[FieldOffset(Offset = "0x1C")]
	public List<Interval> intervals;

	[Token(Token = "0x401B028")]
	[FieldOffset(Offset = "0x20")]
	public List<string> propertyNames;

	[Token(Token = "0x401B029")]
	[FieldOffset(Offset = "0x24")]
	private int MOEGCJNMKLL;

	[Token(Token = "0x401B02A")]
	[FieldOffset(Offset = "0x28")]
	private JNCHOHCCKBF AAOLNPGPLEN;

	[Token(Token = "0x401B02B")]
	[FieldOffset(Offset = "0x2C")]
	private Material JJBLEDKMLMM;

	[Token(Token = "0x401B02C")]
	[FieldOffset(Offset = "0x30")]
	private float NGEHHKJCPOB;

	[Token(Token = "0x401B02D")]
	[FieldOffset(Offset = "0x34")]
	private int MPMCLECOHPK;

	[Token(Token = "0x401B02E")]
	[FieldOffset(Offset = "0x38")]
	private float MPAEMCAJPFE;

	[Token(Token = "0x401B02F")]
	[FieldOffset(Offset = "0x3C")]
	private List<int> FPEGOFNGIGN;

	[Token(Token = "0x401B030")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Interval> HMDOHFBHDOB;

	[Token(Token = "0x17001CAF")]
	public JNCHOHCCKBF NODAPCLBOBB
	{
		[Token(Token = "0x601A26D")]
		[Address(RVA = "0x1D512C0", Offset = "0x1D512C0", VA = "0x1D512C0")]
		get
		{
			return default(JNCHOHCCKBF);
		}
		[Token(Token = "0x601A26C")]
		[Address(RVA = "0x1D512A8", Offset = "0x1D512A8", VA = "0x1D512A8")]
		set
		{
		}
	}

	[Token(Token = "0x601A26B")]
	[Address(RVA = "0x1D51194", Offset = "0x1D51194", VA = "0x1D51194")]
	public UVSeqPlayer()
	{
	}

	[Token(Token = "0x601A26E")]
	[Address(RVA = "0x1D512C8", Offset = "0x1D512C8", VA = "0x1D512C8")]
	private void Start()
	{
	}

	[Token(Token = "0x601A26F")]
	[Address(RVA = "0x1D51D20", Offset = "0x1D51D20", VA = "0x1D51D20")]
	private void Update()
	{
	}

	[Token(Token = "0x601A270")]
	[Address(RVA = "0x1D51EBC", Offset = "0x1D51EBC", VA = "0x1D51EBC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x601A271")]
	[Address(RVA = "0x1D513A8", Offset = "0x1D513A8", VA = "0x1D513A8")]
	public int Count()
	{
		return default(int);
	}

	[Token(Token = "0x601A272")]
	[Address(RVA = "0x1D51808", Offset = "0x1D51808", VA = "0x1D51808")]
	private void HANHJKGABIH()
	{
	}

	[Token(Token = "0x601A273")]
	[Address(RVA = "0x1D51ED4", Offset = "0x1D51ED4", VA = "0x1D51ED4")]
	private static int IGPCFGAGFOE(Interval NHJNFPKBBLI, Interval LGALHNNDGNE)
	{
		return default(int);
	}
}
