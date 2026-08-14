using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032AA")]
public class UIModelVehicleDisplay : UIBaseModel
{
	[Token(Token = "0x40134B1")]
	public const string HDVEHICLEDISPLAYGUIDE = "HDVEHICLEDISPLAYGUIDE_";

	[Token(Token = "0x40134B2")]
	public const string UILobbyVehicleDisplayGuideKey = "UILOBBYVEHICLEDISPLAYGUIDEKEY_";

	[Token(Token = "0x40134B3")]
	public const string UILobbyVehicleAutoRotateGuideKey = "UILOBBYVEHICLE_AUTOROTATE_GUIDEKEY_";

	[Token(Token = "0x40134B4")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CSelectedVehicleSkinID_003Ek__BackingField;

	[Token(Token = "0x40134B5")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	[Token(Token = "0x40134B6")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001696")]
	public uint SelectedVehicleSkinID
	{
		[Token(Token = "0x60155D8")]
		[Address(RVA = "0x16AA19C", Offset = "0x16AA19C", VA = "0x16AA19C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60155D9")]
		[Address(RVA = "0x16AA1A4", Offset = "0x16AA1A4", VA = "0x16AA1A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001697")]
	public bool GetDataAfterLogin
	{
		[Token(Token = "0x60155DA")]
		[Address(RVA = "0x16AA1AC", Offset = "0x16AA1AC", VA = "0x16AA1AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60155DB")]
		[Address(RVA = "0x16AA1B4", Offset = "0x16AA1B4", VA = "0x16AA1B4")]
		private set
		{
		}
	}

	[Token(Token = "0x60155D7")]
	[Address(RVA = "0x16AA118", Offset = "0x16AA118", VA = "0x16AA118")]
	public UIModelVehicleDisplay()
	{
	}

	[Token(Token = "0x60155DC")]
	[Address(RVA = "0x16AA1BC", Offset = "0x16AA1BC", VA = "0x16AA1BC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60155DD")]
	[Address(RVA = "0x16AA214", Offset = "0x16AA214", VA = "0x16AA214", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60155DE")]
	[Address(RVA = "0x16AA290", Offset = "0x16AA290", VA = "0x16AA290")]
	public void ProcessData(uint skinID)
	{
	}

	[Token(Token = "0x60155DF")]
	[Address(RVA = "0x16AA3B0", Offset = "0x16AA3B0", VA = "0x16AA3B0")]
	public void RequestSetVehicleSkinID(uint skinID, bool autoRotate = false)
	{
	}

	[Token(Token = "0x60155E0")]
	[Address(RVA = "0x16AA654", Offset = "0x16AA654", VA = "0x16AA654")]
	private static void _003CRequestSetVehicleSkinID_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60155E1")]
	[Address(RVA = "0x16AA658", Offset = "0x16AA658", VA = "0x16AA658")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
