using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030F5")]
public class UIModelLiveTv : UIBaseModel
{
	[Token(Token = "0x20030F6")]
	private class LiveTvVersion
	{
		[Token(Token = "0x40129EC")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, string> data;

		[Token(Token = "0x601484A")]
		[Address(RVA = "0x3289B94", Offset = "0x3289B94", VA = "0x3289B94")]
		public LiveTvVersion()
		{
		}
	}

	[Token(Token = "0x20030F7")]
	private enum LiveType
	{
		[Token(Token = "0x40129EE")]
		LiveTVReqPointWebRequest = 9999,
		[Token(Token = "0x40129EF")]
		LiveTV = 1,
		[Token(Token = "0x40129F0")]
		BooyahTV = 2
	}

	[Token(Token = "0x40129E2")]
	[FieldOffset(Offset = "0xC")]
	private List<LiveDesc> m_TabDesc;

	[Token(Token = "0x40129E3")]
	[FieldOffset(Offset = "0x0")]
	private static string m_LiveTVLobbyRedTipsVerID;

	[Token(Token = "0x40129E4")]
	[FieldOffset(Offset = "0x10")]
	private bool m_HasRequested;

	[Token(Token = "0x40129E5")]
	[FieldOffset(Offset = "0x14")]
	private int m_Version;

	[Token(Token = "0x40129E6")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<LiveDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40129E7")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<LiveDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40129E8")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<LiveDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40129E9")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<LiveDesc> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40129EA")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<LiveDesc> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40129EB")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<LiveDesc> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x6014834")]
	[Address(RVA = "0x3287C98", Offset = "0x3287C98", VA = "0x3287C98")]
	public UIModelLiveTv()
	{
	}

	[Token(Token = "0x6014835")]
	[Address(RVA = "0x3287D58", Offset = "0x3287D58", VA = "0x3287D58", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014836")]
	[Address(RVA = "0x3287DB0", Offset = "0x3287DB0", VA = "0x3287DB0", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014837")]
	[Address(RVA = "0x3287E30", Offset = "0x3287E30", VA = "0x3287E30")]
	public void ProcessTabDesc(CSGetLiveDescRes live_desc)
	{
	}

	[Token(Token = "0x6014838")]
	[Address(RVA = "0x328802C", Offset = "0x328802C", VA = "0x328802C")]
	public LivePopupDesc GetLiveBubbleData()
	{
		return null;
	}

	[Token(Token = "0x6014839")]
	[Address(RVA = "0x32883A8", Offset = "0x32883A8", VA = "0x32883A8")]
	public string LiveTVURL()
	{
		return null;
	}

	[Token(Token = "0x601483A")]
	[Address(RVA = "0x32886D8", Offset = "0x32886D8", VA = "0x32886D8")]
	public string BooyahTVURL()
	{
		return null;
	}

	[Token(Token = "0x601483B")]
	[Address(RVA = "0x3288A08", Offset = "0x3288A08", VA = "0x3288A08")]
	public string LiveTVReqPointWebRequestURL()
	{
		return null;
	}

	[Token(Token = "0x601483C")]
	[Address(RVA = "0x3288C88", Offset = "0x3288C88", VA = "0x3288C88")]
	public string LiveTabName()
	{
		return null;
	}

	[Token(Token = "0x601483D")]
	[Address(RVA = "0x3288F08", Offset = "0x3288F08", VA = "0x3288F08")]
	public string BooyahTabName()
	{
		return null;
	}

	[Token(Token = "0x601483E")]
	[Address(RVA = "0x3289188", Offset = "0x3289188", VA = "0x3289188")]
	public void LiveTvRedTip(int version)
	{
	}

	[Token(Token = "0x601483F")]
	[Address(RVA = "0x32893CC", Offset = "0x32893CC", VA = "0x32893CC")]
	public void DeactiveLobbyLiveTvRedTip()
	{
	}

	[Token(Token = "0x6014840")]
	[Address(RVA = "0x32895A4", Offset = "0x32895A4", VA = "0x32895A4")]
	public void RequesetLiveTvVersion()
	{
	}

	[Token(Token = "0x6014842")]
	[Address(RVA = "0x3289890", Offset = "0x3289890", VA = "0x3289890")]
	private static bool _003CGetLiveBubbleData_003Em__0(LiveDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014843")]
	[Address(RVA = "0x32898BC", Offset = "0x32898BC", VA = "0x32898BC")]
	private static bool _003CLiveTVURL_003Em__1(LiveDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014844")]
	[Address(RVA = "0x32898E8", Offset = "0x32898E8", VA = "0x32898E8")]
	private static bool _003CBooyahTVURL_003Em__2(LiveDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014845")]
	[Address(RVA = "0x3289918", Offset = "0x3289918", VA = "0x3289918")]
	private static bool _003CLiveTVReqPointWebRequestURL_003Em__3(LiveDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014846")]
	[Address(RVA = "0x328994C", Offset = "0x328994C", VA = "0x328994C")]
	private static bool _003CLiveTabName_003Em__4(LiveDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014847")]
	[Address(RVA = "0x3289978", Offset = "0x3289978", VA = "0x3289978")]
	private static bool _003CBooyahTabName_003Em__5(LiveDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014848")]
	[Address(RVA = "0x32899A8", Offset = "0x32899A8", VA = "0x32899A8")]
	private void _003CRequesetLiveTvVersion_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014849")]
	[Address(RVA = "0x3289B8C", Offset = "0x3289B8C", VA = "0x3289B8C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
