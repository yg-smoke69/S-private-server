using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001FB4")]
public class UIAvatarAwakenTaskItemController : MonoBehaviour
{
	[Token(Token = "0x400C6DE")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Desc;

	[Token(Token = "0x400C6DF")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Process;

	[Token(Token = "0x400C6E0")]
	[FieldOffset(Offset = "0x14")]
	public Transform AwardItem;

	[Token(Token = "0x400C6E1")]
	[FieldOffset(Offset = "0x18")]
	public Transform AwardItem2;

	[Token(Token = "0x400C6E2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton StateButton;

	[Token(Token = "0x400C6E3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject OperateAwarded;

	[Token(Token = "0x400C6E4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OperateFinished;

	[Token(Token = "0x400C6E5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject OperateReceived;

	[Token(Token = "0x400C6E6")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget TaskWidget;

	[Token(Token = "0x400C6E7")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget AdjustWidget;

	[Token(Token = "0x400C6E8")]
	[FieldOffset(Offset = "0x34")]
	private uint m_TaskID;

	[Token(Token = "0x400C6E9")]
	[FieldOffset(Offset = "0x38")]
	private int m_Index;

	[Token(Token = "0x400C6EA")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_AvatarID;

	[Token(Token = "0x400C6EB")]
	[FieldOffset(Offset = "0x40")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400C6EC")]
	[FieldOffset(Offset = "0x44")]
	private EProfile.TaskState m_State;

	[Token(Token = "0x400C6ED")]
	[FieldOffset(Offset = "0x48")]
	private UIStandardItemMiniController m_CacheAward1;

	[Token(Token = "0x400C6EE")]
	[FieldOffset(Offset = "0x4C")]
	private UIStandardItemMiniController m_CacheAward2;

	[Token(Token = "0x6009E74")]
	[Address(RVA = "0x1E863B0", Offset = "0x1E863B0", VA = "0x1E863B0")]
	public UIAvatarAwakenTaskItemController()
	{
	}

	[Token(Token = "0x6009E75")]
	[Address(RVA = "0x1E863B8", Offset = "0x1E863B8", VA = "0x1E863B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6009E76")]
	[Address(RVA = "0x1E7E624", Offset = "0x1E7E624", VA = "0x1E7E624")]
	public void SetData(uint avatarID, AwakenTask taskData, int index)
	{
	}

	[Token(Token = "0x6009E77")]
	[Address(RVA = "0x1E7FB1C", Offset = "0x1E7FB1C", VA = "0x1E7FB1C")]
	public uint GetTaskID()
	{
		return default(uint);
	}

	[Token(Token = "0x6009E78")]
	[Address(RVA = "0x1E7FB74", Offset = "0x1E7FB74", VA = "0x1E7FB74")]
	public int GetUIIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6009E79")]
	[Address(RVA = "0x1E867E8", Offset = "0x1E867E8", VA = "0x1E867E8")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x6009E7A")]
	[Address(RVA = "0x1E865B8", Offset = "0x1E865B8", VA = "0x1E865B8")]
	private void UpdateButtonState(EProfile.TaskState state)
	{
	}

	[Token(Token = "0x6009E7B")]
	[Address(RVA = "0x1E86520", Offset = "0x1E86520", VA = "0x1E86520")]
	private uint GetUnitRatio(uint val, bool needChangeVal)
	{
		return default(uint);
	}
}
