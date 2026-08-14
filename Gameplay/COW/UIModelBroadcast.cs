using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EF7")]
public class UIModelBroadcast : UIBaseModel
{
	[Token(Token = "0x2002EF8")]
	private sealed class _003CLoginGetBroadcast_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011F23")]
		[FieldOffset(Offset = "0x8")]
		internal bool preload;

		[Token(Token = "0x4011F24")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBroadcast _0024this;

		[Token(Token = "0x6013AB9")]
		[Address(RVA = "0x32C7998", Offset = "0x32C7998", VA = "0x32C7998")]
		public _003CLoginGetBroadcast_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013ABA")]
		[Address(RVA = "0x32C8A20", Offset = "0x32C8A20", VA = "0x32C8A20")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EF9")]
	private sealed class _003CProcessBroadcastRes_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011F25")]
		[FieldOffset(Offset = "0x8")]
		internal string myName;

		[Token(Token = "0x6013ABB")]
		[Address(RVA = "0x32C86C0", Offset = "0x32C86C0", VA = "0x32C86C0")]
		public _003CProcessBroadcastRes_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013ABC")]
		[Address(RVA = "0x32C8DE4", Offset = "0x32C8DE4", VA = "0x32C8DE4")]
		internal int _003C_003Em__0(BroadcastMessage a, BroadcastMessage b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4011F1B")]
	[FieldOffset(Offset = "0xC")]
	private List<BroadcastMessage> m_BroadcastMsgList;

	[Token(Token = "0x4011F1C")]
	[FieldOffset(Offset = "0x10")]
	private List<ScrollMarqueeDesc> m_ScrollMarDataList;

	[Token(Token = "0x4011F1D")]
	public const uint PropID_BroadcastRetOK = 2u;

	[Token(Token = "0x4011F1E")]
	public const uint PropID_FriendsOnlineNotify = 4u;

	[Token(Token = "0x4011F1F")]
	public const uint PropID_LoudSpeakerNotify = 8u;

	[Token(Token = "0x4011F20")]
	[FieldOffset(Offset = "0x14")]
	private bool _003CSilenceSwitch_003Ek__BackingField;

	[Token(Token = "0x4011F21")]
	[FieldOffset(Offset = "0x15")]
	private bool m_PreloadBroadcast;

	[Token(Token = "0x4011F22")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ScrollMarqueeDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700146C")]
	public List<BroadcastMessage> BroadcastDataList
	{
		[Token(Token = "0x6013AA7")]
		[Address(RVA = "0x32C67AC", Offset = "0x32C67AC", VA = "0x32C67AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146D")]
	public List<ScrollMarqueeDesc> ScrollMarDataList
	{
		[Token(Token = "0x6013AA8")]
		[Address(RVA = "0x32C6804", Offset = "0x32C6804", VA = "0x32C6804")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146E")]
	public bool SilenceSwitch
	{
		[Token(Token = "0x6013AA9")]
		[Address(RVA = "0x32C6BD0", Offset = "0x32C6BD0", VA = "0x32C6BD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013AAA")]
		[Address(RVA = "0x32C6BD8", Offset = "0x32C6BD8", VA = "0x32C6BD8")]
		private set
		{
		}
	}

	[Token(Token = "0x6013AA5")]
	[Address(RVA = "0x32C6668", Offset = "0x32C6668", VA = "0x32C6668")]
	public UIModelBroadcast()
	{
	}

	[Token(Token = "0x6013AA6")]
	[Address(RVA = "0x32C6754", Offset = "0x32C6754", VA = "0x32C6754", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013AAB")]
	[Address(RVA = "0x32C6BE0", Offset = "0x32C6BE0", VA = "0x32C6BE0", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013AAC")]
	[Address(RVA = "0x32C6D1C", Offset = "0x32C6D1C", VA = "0x32C6D1C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013AAD")]
	[Address(RVA = "0x32C6E20", Offset = "0x32C6E20", VA = "0x32C6E20")]
	public string MakeRollMessage(BroadcastMessage brMsg)
	{
		return null;
	}

	[Token(Token = "0x6013AAE")]
	[Address(RVA = "0x32C74A0", Offset = "0x32C74A0", VA = "0x32C74A0")]
	private void OnLoginGetBroadCast()
	{
	}

	[Token(Token = "0x6013AAF")]
	[Address(RVA = "0x32C7570", Offset = "0x32C7570", VA = "0x32C7570")]
	public void LoginGetBroadcast(bool preload = false)
	{
	}

	[Token(Token = "0x6013AB0")]
	[Address(RVA = "0x32C79A0", Offset = "0x32C79A0", VA = "0x32C79A0")]
	public void RequestBroadcastDataOnly()
	{
	}

	[Token(Token = "0x6013AB1")]
	[Address(RVA = "0x32C7CB8", Offset = "0x32C7CB8", VA = "0x32C7CB8")]
	private void ProcessMarqueeRes(CSScrollMarqueeRes scroll_res)
	{
	}

	[Token(Token = "0x6013AB2")]
	[Address(RVA = "0x32C8030", Offset = "0x32C8030", VA = "0x32C8030")]
	public void ProcessFriendsOnlineNotify(string name, uint intimacy)
	{
	}

	[Token(Token = "0x6013AB3")]
	[Address(RVA = "0x32C82C0", Offset = "0x32C82C0", VA = "0x32C82C0")]
	public void ProcessLoudSpeaker(RollNoticeData data)
	{
	}

	[Token(Token = "0x6013AB4")]
	[Address(RVA = "0x32C83F4", Offset = "0x32C83F4", VA = "0x32C83F4")]
	private void ProcessBroadcastRes(CSGetBroadcastListRes broadcastMsgRes)
	{
	}

	[Token(Token = "0x6013AB5")]
	[Address(RVA = "0x32C86C8", Offset = "0x32C86C8", VA = "0x32C86C8")]
	private void _003CRequestBroadcastDataOnly_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013AB6")]
	[Address(RVA = "0x32C89C8", Offset = "0x32C89C8", VA = "0x32C89C8")]
	private static int _003CProcessMarqueeRes_003Em__1(ScrollMarqueeDesc a, ScrollMarqueeDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6013AB7")]
	[Address(RVA = "0x32C8A10", Offset = "0x32C8A10", VA = "0x32C8A10")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x6013AB8")]
	[Address(RVA = "0x32C8A18", Offset = "0x32C8A18", VA = "0x32C8A18")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
