using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B54")]
internal class UISPHudTeamRankingListController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x4010999")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudTeamRankingListView m_View;

	[Token(Token = "0x401099A")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSpectator m_Model;

	[Token(Token = "0x401099B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsCombatLevelRequesting;

	[Token(Token = "0x401099C")]
	[FieldOffset(Offset = "0x34")]
	private EInfoType m_PrevType;

	[Token(Token = "0x401099D")]
	[FieldOffset(Offset = "0x38")]
	private EInfoType m_InfoType;

	[Token(Token = "0x401099E")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CachedY;

	[Token(Token = "0x170012E3")]
	public EInfoType InfoType
	{
		[Token(Token = "0x6011D84")]
		[Address(RVA = "0x14998D8", Offset = "0x14998D8", VA = "0x14998D8")]
		get
		{
			return default(EInfoType);
		}
	}

	[Token(Token = "0x6011D83")]
	[Address(RVA = "0x149A028", Offset = "0x149A028", VA = "0x149A028")]
	public UISPHudTeamRankingListController()
	{
	}

	[Token(Token = "0x6011D85")]
	[Address(RVA = "0x149A0AC", Offset = "0x149A0AC", VA = "0x149A0AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D86")]
	[Address(RVA = "0x149A154", Offset = "0x149A154", VA = "0x149A154", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D87")]
	[Address(RVA = "0x149A488", Offset = "0x149A488", VA = "0x149A488", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D88")]
	[Address(RVA = "0x149A5E0", Offset = "0x149A5E0", VA = "0x149A5E0")]
	private void OnTogglePanel(object[] data)
	{
	}

	[Token(Token = "0x6011D89")]
	[Address(RVA = "0x149AD00", Offset = "0x149AD00", VA = "0x149AD00", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011D8A")]
	[Address(RVA = "0x149B1A4", Offset = "0x149B1A4", VA = "0x149B1A4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011D8B")]
	[Address(RVA = "0x149B238", Offset = "0x149B238", VA = "0x149B238", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011D8C")]
	[Address(RVA = "0x149B354", Offset = "0x149B354", VA = "0x149B354", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011D8D")]
	[Address(RVA = "0x149B3D0", Offset = "0x149B3D0", VA = "0x149B3D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D8E")]
	[Address(RVA = "0x149B3D8", Offset = "0x149B3D8", VA = "0x149B3D8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
