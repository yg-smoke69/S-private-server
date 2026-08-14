using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20025C9")]
public class UIDebugLoginController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20025CA")]
	private sealed class _003CInitServerView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E9C8")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSVBaseData> serverSettings;

		[Token(Token = "0x600DE24")]
		[Address(RVA = "0x2D7F8F8", Offset = "0x2D7F8F8", VA = "0x2D7F8F8")]
		public _003CInitServerView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DE25")]
		[Address(RVA = "0x2D7FD14", Offset = "0x2D7FD14", VA = "0x2D7FD14")]
		internal void _003C_003Em__0(string server)
		{
		}
	}

	[Token(Token = "0x400E9BF")]
	[FieldOffset(Offset = "0x48")]
	private UIAccountIDNickNameLoginWindowView m_View;

	[Token(Token = "0x400E9C0")]
	private const uint BTN_DEFUALT_COLOR = 1608186111u;

	[Token(Token = "0x400E9C1")]
	private const uint BTN_GREY_COLOR = 2593823487u;

	[Token(Token = "0x400E9C2")]
	private const uint OUTLINE_BLUE = 192872447u;

	[Token(Token = "0x400E9C3")]
	private const uint LABEL_GEM_COLOR = 188765951u;

	[Token(Token = "0x400E9C4")]
	[FieldOffset(Offset = "0x4C")]
	private LoginRes m_UserData;

	[Token(Token = "0x400E9C5")]
	[FieldOffset(Offset = "0x50")]
	private RenameCostData m_CostData;

	[Token(Token = "0x400E9C6")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasRequestedLogin;

	[Token(Token = "0x400E9C7")]
	private const string CacheKey = "DebugLoginCachedName";

	[Token(Token = "0x600DE18")]
	[Address(RVA = "0x2D7EA44", Offset = "0x2D7EA44", VA = "0x2D7EA44")]
	public UIDebugLoginController()
	{
	}

	[Token(Token = "0x600DE19")]
	[Address(RVA = "0x2D7EA4C", Offset = "0x2D7EA4C", VA = "0x2D7EA4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DE1A")]
	[Address(RVA = "0x2D7EAF0", Offset = "0x2D7EAF0", VA = "0x2D7EAF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DE1B")]
	[Address(RVA = "0x2D7EEC0", Offset = "0x2D7EEC0", VA = "0x2D7EEC0")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x600DE1C")]
	[Address(RVA = "0x2D7F7C8", Offset = "0x2D7F7C8", VA = "0x2D7F7C8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DE1D")]
	[Address(RVA = "0x2D7F3CC", Offset = "0x2D7F3CC", VA = "0x2D7F3CC")]
	private void InitServerView()
	{
	}

	[Token(Token = "0x600DE1E")]
	[Address(RVA = "0x2D7F0A4", Offset = "0x2D7F0A4", VA = "0x2D7F0A4")]
	private void OnInputChange()
	{
	}

	[Token(Token = "0x600DE1F")]
	[Address(RVA = "0x2D7F900", Offset = "0x2D7F900", VA = "0x2D7F900")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600DE20")]
	[Address(RVA = "0x2D7FBA0", Offset = "0x2D7FBA0", VA = "0x2D7FBA0", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DE21")]
	[Address(RVA = "0x2D7FC78", Offset = "0x2D7FC78", VA = "0x2D7FC78", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DE22")]
	[Address(RVA = "0x2D7FD04", Offset = "0x2D7FD04", VA = "0x2D7FD04")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DE23")]
	[Address(RVA = "0x2D7FD0C", Offset = "0x2D7FD0C", VA = "0x2D7FD0C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
