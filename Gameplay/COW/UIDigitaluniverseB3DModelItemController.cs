using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EA0")]
public class UIDigitaluniverseB3DModelItemController : MonoBehaviour
{
	[Token(Token = "0x400C07A")]
	[FieldOffset(Offset = "0xC")]
	public string animationClipName;

	[Token(Token = "0x400C07B")]
	[FieldOffset(Offset = "0x10")]
	public Animation anim;

	[Token(Token = "0x400C07C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject guideMask;

	[Token(Token = "0x400C07D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Line;

	[Token(Token = "0x400C07E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Item;

	[Token(Token = "0x400C07F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RedPoint;

	[Token(Token = "0x400C080")]
	[FieldOffset(Offset = "0x24")]
	public bool IsDoor;

	[Token(Token = "0x400C081")]
	[FieldOffset(Offset = "0x28")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C082")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x400C083")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsClickUIElements;

	[Token(Token = "0x400C084")]
	[FieldOffset(Offset = "0x34")]
	public ParticleSystem[] particleSystems;

	[Token(Token = "0x400C085")]
	[FieldOffset(Offset = "0x38")]
	public BoxCollider boxCollider;

	[Token(Token = "0x60093D3")]
	[Address(RVA = "0x2D88668", Offset = "0x2D88668", VA = "0x2D88668")]
	public UIDigitaluniverseB3DModelItemController()
	{
	}

	[Token(Token = "0x60093D4")]
	[Address(RVA = "0x2D88678", Offset = "0x2D88678", VA = "0x2D88678")]
	private void Start()
	{
	}

	[Token(Token = "0x60093D5")]
	[Address(RVA = "0x2D88B40", Offset = "0x2D88B40", VA = "0x2D88B40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60093D6")]
	[Address(RVA = "0x2D88F84", Offset = "0x2D88F84", VA = "0x2D88F84")]
	private void Update()
	{
	}

	[Token(Token = "0x60093D7")]
	[Address(RVA = "0x2D88FD8", Offset = "0x2D88FD8", VA = "0x2D88FD8")]
	public void SetColliderState(bool show)
	{
	}

	[Token(Token = "0x60093D8")]
	[Address(RVA = "0x2D890E0", Offset = "0x2D890E0", VA = "0x2D890E0")]
	public void SetRedPointState(bool show)
	{
	}

	[Token(Token = "0x60093D9")]
	[Address(RVA = "0x2D891E8", Offset = "0x2D891E8", VA = "0x2D891E8")]
	public void SetItemState(bool show)
	{
	}

	[Token(Token = "0x60093DA")]
	[Address(RVA = "0x2D892F0", Offset = "0x2D892F0", VA = "0x2D892F0")]
	public void SetCoreState(uint num)
	{
	}

	[Token(Token = "0x60093DB")]
	[Address(RVA = "0x2D895B0", Offset = "0x2D895B0", VA = "0x2D895B0")]
	public void SetDoorAnimState(DoorState state)
	{
	}

	[Token(Token = "0x60093DC")]
	[Address(RVA = "0x2D8989C", Offset = "0x2D8989C", VA = "0x2D8989C")]
	private void FingerUp(LeanFinger finger)
	{
	}

	[Token(Token = "0x60093DD")]
	[Address(RVA = "0x2D898F8", Offset = "0x2D898F8", VA = "0x2D898F8")]
	private void FingerTap(LeanFinger finger)
	{
	}

	[Token(Token = "0x60093DE")]
	[Address(RVA = "0x2D89F88", Offset = "0x2D89F88", VA = "0x2D89F88")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x60093DF")]
	[Address(RVA = "0x2D89A68", Offset = "0x2D89A68", VA = "0x2D89A68")]
	private bool CheckIsTouchModel(Vector2 touchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60093E0")]
	[Address(RVA = "0x2D89D40", Offset = "0x2D89D40", VA = "0x2D89D40")]
	private void OnTouchModel()
	{
	}

	[Token(Token = "0x60093E1")]
	[Address(RVA = "0x2D8A050", Offset = "0x2D8A050", VA = "0x2D8A050")]
	private void OnTriggerEnter(Collider other)
	{
	}
}
