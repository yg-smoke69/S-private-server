using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002C4E")]
internal class UIWereWolvesRoomParamItemController : UIBaseController
{
	[Token(Token = "0x4010E48")]
	[FieldOffset(Offset = "0x28")]
	private UIWereWolvesRoomParamItemView m_View;

	[Token(Token = "0x4010E49")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CurParamValue;

	[Token(Token = "0x4010E4A")]
	[FieldOffset(Offset = "0x30")]
	private IANLBOJBCIO m_ParamType;

	[Token(Token = "0x4010E4B")]
	[FieldOffset(Offset = "0x34")]
	private Action<IANLBOJBCIO, uint> m_ParamChangeCallBack;

	[Token(Token = "0x4010E4C")]
	[FieldOffset(Offset = "0x38")]
	private WereWolvesRoomSettingData m_SettingData;

	[Token(Token = "0x1700132D")]
	private uint CurParamValue
	{
		[Token(Token = "0x60127DD")]
		[Address(RVA = "0x1B8C5CC", Offset = "0x1B8C5CC", VA = "0x1B8C5CC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60127DE")]
		[Address(RVA = "0x1B8C624", Offset = "0x1B8C624", VA = "0x1B8C624")]
		set
		{
		}
	}

	[Token(Token = "0x60127DC")]
	[Address(RVA = "0x1B8C548", Offset = "0x1B8C548", VA = "0x1B8C548")]
	public UIWereWolvesRoomParamItemController()
	{
	}

	[Token(Token = "0x60127DF")]
	[Address(RVA = "0x1B8C7B8", Offset = "0x1B8C7B8", VA = "0x1B8C7B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60127E0")]
	[Address(RVA = "0x1B8C860", Offset = "0x1B8C860", VA = "0x1B8C860", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60127E1")]
	[Address(RVA = "0x1B8CB18", Offset = "0x1B8CB18", VA = "0x1B8CB18")]
	public void InitSettingData(IANLBOJBCIO paramType, WereWolvesRoomSettingData settingData, Action<IANLBOJBCIO, uint> callBack)
	{
	}

	[Token(Token = "0x60127E2")]
	[Address(RVA = "0x1B8CDF4", Offset = "0x1B8CDF4", VA = "0x1B8CDF4")]
	public void UpdateCurParam(uint param)
	{
	}

	[Token(Token = "0x60127E3")]
	[Address(RVA = "0x1B8CE60", Offset = "0x1B8CE60", VA = "0x1B8CE60")]
	public void ResetMin(uint param)
	{
	}

	[Token(Token = "0x60127E4")]
	[Address(RVA = "0x1B8CFD4", Offset = "0x1B8CFD4", VA = "0x1B8CFD4")]
	private void OnClickMin()
	{
	}

	[Token(Token = "0x60127E5")]
	[Address(RVA = "0x1B8D04C", Offset = "0x1B8D04C", VA = "0x1B8D04C")]
	private void OnClickMax()
	{
	}

	[Token(Token = "0x60127E6")]
	[Address(RVA = "0x1B8D0C4", Offset = "0x1B8D0C4", VA = "0x1B8D0C4")]
	private void OnClickPlus()
	{
	}

	[Token(Token = "0x60127E7")]
	[Address(RVA = "0x1B8D14C", Offset = "0x1B8D14C", VA = "0x1B8D14C")]
	private void OnClickSub()
	{
	}

	[Token(Token = "0x60127E8")]
	[Address(RVA = "0x1B8D1D4", Offset = "0x1B8D1D4", VA = "0x1B8D1D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
