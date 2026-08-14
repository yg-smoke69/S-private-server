using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMA.Simple;

[Token(Token = "0x2003C77")]
public class SlotOverlayAssetCacheData
{
	[Token(Token = "0x4019B1D")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<int, SlotDataAsset> m_SlotCache;

	[Token(Token = "0x4019B1E")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<int, OverlayDataAsset> m_OverlayCache;

	[Token(Token = "0x4019B1F")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<uint, AsyncLoadReq> m_LoadingReqs;

	[Token(Token = "0x4019B20")]
	[FieldOffset(Offset = "0x14")]
	public AsyncLoadReqPool m_ReqPool;

	[Token(Token = "0x4019B21")]
	[FieldOffset(Offset = "0x18")]
	public Sample m_SyncSample;

	[Token(Token = "0x601825C")]
	[Address(RVA = "0x2D5A438", Offset = "0x2D5A438", VA = "0x2D5A438")]
	public SlotOverlayAssetCacheData()
	{
	}
}
