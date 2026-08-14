using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005A0")]
public class AirtransportParams : MonoBehaviour
{
	[Token(Token = "0x20005A1")]
	public enum NFGOGEEFKEH
	{
		[Token(Token = "0x4004354")]
		RankedMatch,
		[Token(Token = "0x4004355")]
		CasualMatchNormal,
		[Token(Token = "0x4004356")]
		CasualMatchNewbie
	}

	[Token(Token = "0x4004347")]
	[FieldOffset(Offset = "0xC")]
	public Transform InnerSphere;

	[Token(Token = "0x4004348")]
	[FieldOffset(Offset = "0x10")]
	public Transform OuterSphere;

	[Token(Token = "0x4004349")]
	[FieldOffset(Offset = "0x14")]
	public float EndJumpDeltaMin;

	[Token(Token = "0x400434A")]
	[FieldOffset(Offset = "0x18")]
	public float StartJump;

	[Token(Token = "0x400434B")]
	[FieldOffset(Offset = "0x1C")]
	public float EndJump;

	[Token(Token = "0x400434C")]
	[FieldOffset(Offset = "0x20")]
	public float EndJumpMin;

	[Token(Token = "0x400434D")]
	[FieldOffset(Offset = "0x24")]
	public float EndJumpMax;

	[Token(Token = "0x400434E")]
	[FieldOffset(Offset = "0x28")]
	public float Duration;

	[Token(Token = "0x400434F")]
	[FieldOffset(Offset = "0x2C")]
	public NFGOGEEFKEH MatchType;

	[Token(Token = "0x4004350")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<IHAAMHPPLMG, float> ENJFDLDGBGE;

	[Token(Token = "0x4004351")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 OMKFIMGDEOE;

	[Token(Token = "0x4004352")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 LIINANODJLN;

	[Token(Token = "0x170002D1")]
	public Vector3 BOGOIAMJFDN
	{
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x1137DC8", Offset = "0x1137DC8", VA = "0x1137DC8")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002D2")]
	public Vector3 BCJFHJOHMEP
	{
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x1137D58", Offset = "0x1137D58", VA = "0x1137D58")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x6002242")]
	[Address(RVA = "0x113EC98", Offset = "0x113EC98", VA = "0x113EC98")]
	public AirtransportParams()
	{
	}

	[Token(Token = "0x6002245")]
	[Address(RVA = "0x1138B2C", Offset = "0x1138B2C", VA = "0x1138B2C")]
	public float GetEndJumpRatio(IHAAMHPPLMG BECFAIOFONM)
	{
		return default(float);
	}

	[Token(Token = "0x6002246")]
	[Address(RVA = "0x113E540", Offset = "0x113E540", VA = "0x113E540")]
	public void SetStartPosition(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6002247")]
	[Address(RVA = "0x113E5C8", Offset = "0x113E5C8", VA = "0x113E5C8")]
	public void SetEndPosition(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6002248")]
	[Address(RVA = "0x113EDA4", Offset = "0x113EDA4", VA = "0x113EDA4")]
	public void Init(Vector3 BNDPJDJAFOM, Vector3 NFCLOPBEKGN, int KAHNGJILBFE, float HOFDDLDIGJD, float HGBMGJGAHJN)
	{
	}
}
