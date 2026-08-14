using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027A0")]
internal abstract class UIHudKillNotificationBaseController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F4A3")]
	[FieldOffset(Offset = "0x28")]
	protected UIModelMatch m_Model;

	[Token(Token = "0x400F4A4")]
	[FieldOffset(Offset = "0x2C")]
	protected uint m_DelayCallID;

	[Token(Token = "0x600F447")]
	[Address(RVA = "0x1BB2F30", Offset = "0x1BB2F30", VA = "0x1BB2F30")]
	protected UIHudKillNotificationBaseController()
	{
	}

	[Token(Token = "0x600F448")]
	[Address(RVA = "0x1BB2FB4", Offset = "0x1BB2FB4", VA = "0x1BB2FB4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F449")]
	[Address(RVA = "0x1BB30E8", Offset = "0x1BB30E8", VA = "0x1BB30E8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F44A")]
	[Address(RVA = "0x1BB3164", Offset = "0x1BB3164", VA = "0x1BB3164", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F44B")]
	[Address(RVA = "0x1BB31DC", Offset = "0x1BB31DC", VA = "0x1BB31DC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F44C")]
	[Address(RVA = "0x1BB3274", Offset = "0x1BB3274", VA = "0x1BB3274", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F44D")]
	protected abstract void OnKill(Player killer, Player beKiller, object[] param);

	[Token(Token = "0x600F44E")]
	[Address(RVA = "0x1BB3718", Offset = "0x1BB3718", VA = "0x1BB3718", Slot = "34")]
	protected virtual void OnTargetPlayerKill(object[] param)
	{
	}

	[Token(Token = "0x600F44F")]
	[Address(RVA = "0x1BB3774", Offset = "0x1BB3774", VA = "0x1BB3774", Slot = "35")]
	protected virtual void OnKnockOtherDown(object[] param)
	{
	}

	[Token(Token = "0x600F450")]
	[Address(RVA = "0x1BB37D0", Offset = "0x1BB37D0", VA = "0x1BB37D0")]
	protected void Show(float secs)
	{
	}

	[Token(Token = "0x600F451")]
	[Address(RVA = "0x1BB3960", Offset = "0x1BB3960", VA = "0x1BB3960")]
	protected void CancelHide()
	{
	}

	[Token(Token = "0x600F452")]
	[Address(RVA = "0x1BB3A70", Offset = "0x1BB3A70", VA = "0x1BB3A70")]
	protected void WaitAndHide()
	{
	}

	[Token(Token = "0x600F453")]
	[Address(RVA = "0x1BB3AE4", Offset = "0x1BB3AE4", VA = "0x1BB3AE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F454")]
	[Address(RVA = "0x1BB3AEC", Offset = "0x1BB3AEC", VA = "0x1BB3AEC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F455")]
	[Address(RVA = "0x1BB3AF4", Offset = "0x1BB3AF4", VA = "0x1BB3AF4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
