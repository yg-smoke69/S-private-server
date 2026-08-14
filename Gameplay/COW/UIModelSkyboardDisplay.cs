using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003258")]
public class UIModelSkyboardDisplay : UIBaseModel
{
	[Token(Token = "0x401325C")]
	public const string HDSKYBOARDDISPLAYGUIDE = "HDSKYBOARDDISPLAYGUIDE_";

	[Token(Token = "0x401325D")]
	public const string UILobbySkyboardDisplayGuideKey = "UILOBBYSKYBOARDDISPLAYGUIDEKEY_";

	[Token(Token = "0x401325E")]
	public const string UILobbySkyboardAutoRotateGuideKey = "UILOBBYSKYBOARDAUTOROTATEGUIDEKEY_";

	[Token(Token = "0x401325F")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CSelectedSkyboardSkinID_003Ek__BackingField;

	[Token(Token = "0x4013260")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	[Token(Token = "0x4013261")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700165A")]
	public uint SelectedSkyboardSkinID
	{
		[Token(Token = "0x60153C1")]
		[Address(RVA = "0x30F3660", Offset = "0x30F3660", VA = "0x30F3660")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60153C2")]
		[Address(RVA = "0x30F3668", Offset = "0x30F3668", VA = "0x30F3668")]
		private set
		{
		}
	}

	[Token(Token = "0x1700165B")]
	public bool GetDataAfterLogin
	{
		[Token(Token = "0x60153C3")]
		[Address(RVA = "0x30F3670", Offset = "0x30F3670", VA = "0x30F3670")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60153C4")]
		[Address(RVA = "0x30F3678", Offset = "0x30F3678", VA = "0x30F3678")]
		private set
		{
		}
	}

	[Token(Token = "0x60153C0")]
	[Address(RVA = "0x30F35DC", Offset = "0x30F35DC", VA = "0x30F35DC")]
	public UIModelSkyboardDisplay()
	{
	}

	[Token(Token = "0x60153C5")]
	[Address(RVA = "0x30F3680", Offset = "0x30F3680", VA = "0x30F3680", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60153C6")]
	[Address(RVA = "0x30F36D8", Offset = "0x30F36D8", VA = "0x30F36D8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60153C7")]
	[Address(RVA = "0x30F3754", Offset = "0x30F3754", VA = "0x30F3754")]
	public void ProcessData(uint SkinID)
	{
	}

	[Token(Token = "0x60153C8")]
	[Address(RVA = "0x30F3874", Offset = "0x30F3874", VA = "0x30F3874")]
	public void RequestSetSkyboardSkinID(uint skinID, bool autoRotate = false)
	{
	}

	[Token(Token = "0x60153C9")]
	[Address(RVA = "0x30F3B34", Offset = "0x30F3B34", VA = "0x30F3B34")]
	private static void _003CRequestSetSkyboardSkinID_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60153CA")]
	[Address(RVA = "0x30F3B38", Offset = "0x30F3B38", VA = "0x30F3B38")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
