using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026A2")]
internal class UIGameModeClassicInfoController : UIBaseController
{
	[Token(Token = "0x20026A3")]
	private sealed class _003COnHLDefaultMap_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EE54")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData mapdata;

		[Token(Token = "0x600E886")]
		[Address(RVA = "0x217A148", Offset = "0x217A148", VA = "0x217A148")]
		public _003COnHLDefaultMap_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E887")]
		[Address(RVA = "0x217A160", Offset = "0x217A160", VA = "0x217A160")]
		internal bool _003C_003Em__0(MapModeData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EE4E")]
	[FieldOffset(Offset = "0x28")]
	private UIGameModeClassicInfoView m_View;

	[Token(Token = "0x400EE4F")]
	[FieldOffset(Offset = "0x2C")]
	private List<MapModeData> m_Data;

	[Token(Token = "0x400EE50")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EE51")]
	[FieldOffset(Offset = "0x34")]
	private UIModelLadderMatch m_ladderModel;

	[Token(Token = "0x400EE52")]
	[FieldOffset(Offset = "0x38")]
	private MapModeData m_SelectedMapModeData;

	[Token(Token = "0x400EE53")]
	[FieldOffset(Offset = "0x3C")]
	public UIGameModeMainController GameModeMainController;

	[Token(Token = "0x600E879")]
	[Address(RVA = "0x2177130", Offset = "0x2177130", VA = "0x2177130")]
	public UIGameModeClassicInfoController()
	{
	}

	[Token(Token = "0x600E87A")]
	[Address(RVA = "0x21771B4", Offset = "0x21771B4", VA = "0x21771B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E87B")]
	[Address(RVA = "0x217725C", Offset = "0x217725C", VA = "0x217725C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E87C")]
	[Address(RVA = "0x21776F8", Offset = "0x21776F8", VA = "0x21776F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E87D")]
	[Address(RVA = "0x2177894", Offset = "0x2177894", VA = "0x2177894")]
	public void SetUIData(List<MapModeData> dataList)
	{
	}

	[Token(Token = "0x600E87E")]
	[Address(RVA = "0x2179490", Offset = "0x2179490", VA = "0x2179490")]
	private void OnHelpBtnCLick()
	{
	}

	[Token(Token = "0x600E87F")]
	[Address(RVA = "0x21796CC", Offset = "0x21796CC", VA = "0x21796CC")]
	private bool ShowHelpBtn(MapModeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600E880")]
	[Address(RVA = "0x2179814", Offset = "0x2179814", VA = "0x2179814")]
	private void UpdateSelectedMapName(object[] data)
	{
	}

	[Token(Token = "0x600E881")]
	[Address(RVA = "0x2177A00", Offset = "0x2177A00", VA = "0x2177A00")]
	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	[Token(Token = "0x600E882")]
	[Address(RVA = "0x2179C10", Offset = "0x2179C10", VA = "0x2179C10")]
	private void RefreshOpeningUI()
	{
	}

	[Token(Token = "0x600E883")]
	[Address(RVA = "0x2179D38", Offset = "0x2179D38", VA = "0x2179D38")]
	private void OnHLDefaultMap(object[] data)
	{
	}

	[Token(Token = "0x600E884")]
	[Address(RVA = "0x217A150", Offset = "0x217A150", VA = "0x217A150")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E885")]
	[Address(RVA = "0x217A158", Offset = "0x217A158", VA = "0x217A158")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
