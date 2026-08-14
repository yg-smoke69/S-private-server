using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000689")]
internal class LevelRedEnvelope : BaseLevelObject
{
	[Token(Token = "0x4004875")]
	[FieldOffset(Offset = "0x74")]
	public Transform TitleNode;

	[Token(Token = "0x4004876")]
	[FieldOffset(Offset = "0x78")]
	public GameObject AliveEffect;

	[Token(Token = "0x4004877")]
	[FieldOffset(Offset = "0x7C")]
	private APIJKCCNPGG KPFGHMNBAAD;

	[Token(Token = "0x4004878")]
	[FieldOffset(Offset = "0x80")]
	private IHAAMHPPLMG ACBDIDHNNOF;

	[Token(Token = "0x4004879")]
	[FieldOffset(Offset = "0x98")]
	private string JEDOHLBEIGM;

	[Token(Token = "0x400487A")]
	[FieldOffset(Offset = "0x9C")]
	private bool PNBBLOPDKMJ;

	[Token(Token = "0x400487B")]
	[FieldOffset(Offset = "0xA0")]
	private UIHudNameRedEnvelopeController IMLDNOBBAEI;

	[Token(Token = "0x400487C")]
	[FieldOffset(Offset = "0xA4")]
	private List<RedEnvelopeAwardDisplayInfo> GOPMJPGDIDI;

	[Token(Token = "0x400487D")]
	[FieldOffset(Offset = "0xA8")]
	private RedEnvelopeAwardDisplayInfo BMKIHNDDCAA;

	[Token(Token = "0x17000336")]
	public bool KLPACHKFNBD
	{
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x20C7B18", Offset = "0x20C7B18", VA = "0x20C7B18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000337")]
	public List<RedEnvelopeAwardDisplayInfo> CMGLMEPAJJN
	{
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x20C7B70", Offset = "0x20C7B70", VA = "0x20C7B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000338")]
	public IHAAMHPPLMG CMEKDNHLCGK
	{
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x20C7BC8", Offset = "0x20C7BC8", VA = "0x20C7BC8")]
		get
		{
			return default(IHAAMHPPLMG);
		}
	}

	[Token(Token = "0x17000339")]
	public string EJHHMGGMNKB
	{
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x20C7C3C", Offset = "0x20C7C3C", VA = "0x20C7C3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700033A")]
	public APIJKCCNPGG BMGFJNKPHBI
	{
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x20C7C94", Offset = "0x20C7C94", VA = "0x20C7C94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700033B")]
	public RedEnvelopeAwardDisplayInfo BKCOOAKBPMC
	{
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x20C7F44", Offset = "0x20C7F44", VA = "0x20C7F44")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x20C7F9C", Offset = "0x20C7F9C", VA = "0x20C7F9C")]
		set
		{
		}
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x20C79E4", Offset = "0x20C79E4", VA = "0x20C79E4")]
	public LevelRedEnvelope()
	{
	}

	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x20C7CEC", Offset = "0x20C7CEC", VA = "0x20C7CEC", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x20C7D50", Offset = "0x20C7D50", VA = "0x20C7D50", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x20C7EA0", Offset = "0x20C7EA0", VA = "0x20C7EA0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x20C7FFC", Offset = "0x20C7FFC", VA = "0x20C7FFC")]
	public void Init(APIJKCCNPGG AJKBOONEOAB, ulong AOGJNMFCIPL)
	{
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x20C81B4", Offset = "0x20C81B4", VA = "0x20C81B4")]
	public void AddReceivedAward(PGNMHILNIDG PKPLCPPJMND)
	{
	}

	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x20C8920", Offset = "0x20C8920", VA = "0x20C8920", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60029F0")]
	[Address(RVA = "0x20C8AAC", Offset = "0x20C8AAC", VA = "0x20C8AAC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x20C8B04", Offset = "0x20C8B04", VA = "0x20C8B04")]
	protected void AEJHHELPEFJ(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x20C8C58", Offset = "0x20C8C58", VA = "0x20C8C58")]
	public void AddNameHud()
	{
	}

	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x20C8E38", Offset = "0x20C8E38", VA = "0x20C8E38")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60029F4")]
	[Address(RVA = "0x20C8E40", Offset = "0x20C8E40", VA = "0x20C8E40")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x60029F5")]
	[Address(RVA = "0x20C8E48", Offset = "0x20C8E48", VA = "0x20C8E48")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60029F6")]
	[Address(RVA = "0x20C8E50", Offset = "0x20C8E50", VA = "0x20C8E50")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}
}
