using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026A5")]
internal class UIGameModeCSRankInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EE5C")]
	[FieldOffset(Offset = "0x28")]
	private UIGameModeCSRankInfoView m_View;

	[Token(Token = "0x400EE5D")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EE5E")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_StarList;

	[Token(Token = "0x400EE5F")]
	[FieldOffset(Offset = "0x34")]
	private List<GameObject> m_BlackStarList;

	[Token(Token = "0x400EE60")]
	[FieldOffset(Offset = "0x38")]
	private MapModeData m_SelectedMapModeData;

	[Token(Token = "0x600E89F")]
	[Address(RVA = "0x246668C", Offset = "0x246668C", VA = "0x246668C")]
	public UIGameModeCSRankInfoController()
	{
	}

	[Token(Token = "0x600E8A0")]
	[Address(RVA = "0x2466710", Offset = "0x2466710", VA = "0x2466710")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E8A1")]
	[Address(RVA = "0x24667B8", Offset = "0x24667B8", VA = "0x24667B8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E8A2")]
	[Address(RVA = "0x246684C", Offset = "0x246684C", VA = "0x246684C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E8A3")]
	[Address(RVA = "0x24669A8", Offset = "0x24669A8", VA = "0x24669A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E8A4")]
	[Address(RVA = "0x2466FA0", Offset = "0x2466FA0", VA = "0x2466FA0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E8A5")]
	[Address(RVA = "0x24623D0", Offset = "0x24623D0", VA = "0x24623D0")]
	public void SetUIData(List<MapModeData> data)
	{
	}

	[Token(Token = "0x600E8A6")]
	[Address(RVA = "0x2466918", Offset = "0x2466918", VA = "0x2466918")]
	private void UpdateCSDataInfo()
	{
	}

	[Token(Token = "0x600E8A7")]
	[Address(RVA = "0x24670D0", Offset = "0x24670D0", VA = "0x24670D0")]
	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	[Token(Token = "0x600E8A8")]
	[Address(RVA = "0x24672A0", Offset = "0x24672A0", VA = "0x24672A0")]
	private void ShowHelpBtn(MapModeData data)
	{
	}

	[Token(Token = "0x600E8A9")]
	[Address(RVA = "0x24673CC", Offset = "0x24673CC", VA = "0x24673CC")]
	private void RefreshCSLadderInfo(ResourceID id, int star)
	{
	}

	[Token(Token = "0x600E8AA")]
	[Address(RVA = "0x24681E0", Offset = "0x24681E0", VA = "0x24681E0")]
	private void OnBtnCSRankClick()
	{
	}

	[Token(Token = "0x600E8AB")]
	[Address(RVA = "0x2468364", Offset = "0x2468364", VA = "0x2468364")]
	private void OnHelpBtnCLick()
	{
	}

	[Token(Token = "0x600E8AC")]
	[Address(RVA = "0x246870C", Offset = "0x246870C", VA = "0x246870C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E8AD")]
	[Address(RVA = "0x2468714", Offset = "0x2468714", VA = "0x2468714")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
