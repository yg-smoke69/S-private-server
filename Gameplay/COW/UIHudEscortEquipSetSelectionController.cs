using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002741")]
public class UIHudEscortEquipSetSelectionController : UIBaseController
{
	[Token(Token = "0x400F23D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortEquipSetSelectionView m_View;

	[Token(Token = "0x400F23E")]
	[FieldOffset(Offset = "0x2C")]
	private UIEscortEquipSetItemController m_SelectSetUI;

	[Token(Token = "0x400F23F")]
	[FieldOffset(Offset = "0x30")]
	private List<UIEscortEquipSetItemController> m_SetItemUIs;

	[Token(Token = "0x400F240")]
	[FieldOffset(Offset = "0x34")]
	private UITimeLabelHelper m_EndTime;

	[Token(Token = "0x400F241")]
	private const int m_MaxItemCout = 6;

	[Token(Token = "0x600EF62")]
	[Address(RVA = "0x1B9221C", Offset = "0x1B9221C", VA = "0x1B9221C")]
	public UIHudEscortEquipSetSelectionController()
	{
	}

	[Token(Token = "0x600EF63")]
	[Address(RVA = "0x1B922A0", Offset = "0x1B922A0", VA = "0x1B922A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF64")]
	[Address(RVA = "0x1B92348", Offset = "0x1B92348", VA = "0x1B92348", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF65")]
	[Address(RVA = "0x1B932A4", Offset = "0x1B932A4", VA = "0x1B932A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EF66")]
	[Address(RVA = "0x1B93440", Offset = "0x1B93440", VA = "0x1B93440")]
	private void OnRefreshEquip(object[] param)
	{
	}

	[Token(Token = "0x600EF67")]
	[Address(RVA = "0x1B9349C", Offset = "0x1B9349C", VA = "0x1B9349C")]
	private void OnUpdateEquip(object[] param)
	{
	}

	[Token(Token = "0x600EF68")]
	[Address(RVA = "0x1B92F1C", Offset = "0x1B92F1C", VA = "0x1B92F1C")]
	private int GetEquipSetUIIndex(uint equipSetID)
	{
		return default(int);
	}

	[Token(Token = "0x600EF69")]
	[Address(RVA = "0x1B92E34", Offset = "0x1B92E34", VA = "0x1B92E34")]
	public void SetStartState()
	{
	}

	[Token(Token = "0x600EF6A")]
	[Address(RVA = "0x1B930F4", Offset = "0x1B930F4", VA = "0x1B930F4")]
	private void OnSelectItem(int index)
	{
	}

	[Token(Token = "0x600EF6B")]
	[Address(RVA = "0x1B92D88", Offset = "0x1B92D88", VA = "0x1B92D88")]
	private void SetConfirmButtonState(bool canclick)
	{
	}

	[Token(Token = "0x600EF6C")]
	[Address(RVA = "0x1B934F8", Offset = "0x1B934F8", VA = "0x1B934F8")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x600EF6D")]
	[Address(RVA = "0x1B92D34", Offset = "0x1B92D34", VA = "0x1B92D34")]
	private void RequestEquipInfo()
	{
	}

	[Token(Token = "0x600EF6E")]
	[Address(RVA = "0x1B93870", Offset = "0x1B93870", VA = "0x1B93870")]
	private void Update()
	{
	}

	[Token(Token = "0x600EF6F")]
	[Address(RVA = "0x1B93910", Offset = "0x1B93910", VA = "0x1B93910", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EF70")]
	[Address(RVA = "0x1B93974", Offset = "0x1B93974", VA = "0x1B93974")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF71")]
	[Address(RVA = "0x1B9397C", Offset = "0x1B9397C", VA = "0x1B9397C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EF72")]
	[Address(RVA = "0x1B93984", Offset = "0x1B93984", VA = "0x1B93984")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
