using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200231A")]
public class SceneEditActionDragDrop : UIDragDropItem
{
	[Token(Token = "0x400DADB")]
	[FieldOffset(Offset = "0x6C")]
	private ResourceID mDragResID;

	[Token(Token = "0x400DADC")]
	[FieldOffset(Offset = "0x70")]
	private GameObject mDragCrosshair;

	[Token(Token = "0x600C257")]
	[Address(RVA = "0x241E0B8", Offset = "0x241E0B8", VA = "0x241E0B8")]
	public SceneEditActionDragDrop()
	{
	}

	[Token(Token = "0x600C258")]
	[Address(RVA = "0x241E184", Offset = "0x241E184", VA = "0x241E184", Slot = "7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600C259")]
	[Address(RVA = "0x241E1F0", Offset = "0x241E1F0", VA = "0x241E1F0")]
	public void SetDragPrefabResID(uint itemID, ResourceID resID)
	{
	}

	[Token(Token = "0x600C25A")]
	[Address(RVA = "0x241E26C", Offset = "0x241E26C", VA = "0x241E26C")]
	private void SetDragging(bool d)
	{
	}

	[Token(Token = "0x600C25B")]
	[Address(RVA = "0x241E3A4", Offset = "0x241E3A4", VA = "0x241E3A4")]
	private Vector3 GetCrosshairPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600C25C")]
	[Address(RVA = "0x241E778", Offset = "0x241E778", VA = "0x241E778", Slot = "18")]
	protected override void OnDragDropStart()
	{
	}

	[Token(Token = "0x600C25D")]
	[Address(RVA = "0x241EB50", Offset = "0x241EB50", VA = "0x241EB50", Slot = "19")]
	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	[Token(Token = "0x600C25E")]
	[Address(RVA = "0x241ECB0", Offset = "0x241ECB0", VA = "0x241ECB0", Slot = "20")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x600C25F")]
	[Address(RVA = "0x241EE18", Offset = "0x241EE18", VA = "0x241EE18", Slot = "17")]
	public override void OnDragOverObject(GameObject go)
	{
	}

	[Token(Token = "0x600C260")]
	[Address(RVA = "0x241EE88", Offset = "0x241EE88", VA = "0x241EE88")]
	public void OnApplicationPause(bool pauseState)
	{
	}

	[Token(Token = "0x600C261")]
	[Address(RVA = "0x241EF00", Offset = "0x241EF00", VA = "0x241EF00")]
	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	[Token(Token = "0x600C262")]
	[Address(RVA = "0x241EF08", Offset = "0x241EF08", VA = "0x241EF08")]
	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	[Token(Token = "0x600C263")]
	[Address(RVA = "0x241EF10", Offset = "0x241EF10", VA = "0x241EF10")]
	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	[Token(Token = "0x600C264")]
	[Address(RVA = "0x241EF18", Offset = "0x241EF18", VA = "0x241EF18")]
	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	[Token(Token = "0x600C265")]
	[Address(RVA = "0x241EF20", Offset = "0x241EF20", VA = "0x241EF20")]
	public void _003C_003EiFixBaseProxy_OnDragOverObject(GameObject P0)
	{
	}
}
