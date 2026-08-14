using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2000A3B")]
public class PreviewStoryCgCdnComp : MonoBehaviour
{
	[Token(Token = "0x4005B4C")]
	[FieldOffset(Offset = "0xC")]
	public UINetworkTexture m_Typetitlenettex;

	[Token(Token = "0x4005B4D")]
	[FieldOffset(Offset = "0x10")]
	public UINetworkTexture m_Maintitlenettex;

	[Token(Token = "0x4005B4E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_Maintitledefault;

	[Token(Token = "0x4005B4F")]
	[FieldOffset(Offset = "0x18")]
	public uint CdnMainId;

	[Token(Token = "0x4005B50")]
	[FieldOffset(Offset = "0x1C")]
	public uint CdnTypeId;

	[Token(Token = "0x6004F90")]
	[Address(RVA = "0x195D2C4", Offset = "0x195D2C4", VA = "0x195D2C4")]
	public PreviewStoryCgCdnComp()
	{
	}

	[Token(Token = "0x6004F91")]
	[Address(RVA = "0x195D2CC", Offset = "0x195D2CC", VA = "0x195D2CC")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6004F92")]
	[Address(RVA = "0x195D4E0", Offset = "0x195D4E0", VA = "0x195D4E0")]
	public void RefreshMainTitleCdnTex(string url)
	{
	}

	[Token(Token = "0x6004F93")]
	[Address(RVA = "0x195D814", Offset = "0x195D814", VA = "0x195D814")]
	private bool _003CAwake_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}
}
