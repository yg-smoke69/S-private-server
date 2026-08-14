using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003ACC")]
public class TaskDragDropContainer : UIDragDropContainer
{
	[Token(Token = "0x4018FB6")]
	[FieldOffset(Offset = "0x10")]
	public Transform[] targetPosition;

	[Token(Token = "0x4018FB7")]
	[FieldOffset(Offset = "0x14")]
	public bool attached;

	[Token(Token = "0x4018FB8")]
	[FieldOffset(Offset = "0x18")]
	public int tag;

	[Token(Token = "0x4018FB9")]
	[FieldOffset(Offset = "0x1C")]
	public int value;

	[Token(Token = "0x4018FBA")]
	[FieldOffset(Offset = "0x20")]
	private int m_TarIdx;

	[Token(Token = "0x601748A")]
	[Address(RVA = "0x28969A0", Offset = "0x28969A0", VA = "0x28969A0")]
	public TaskDragDropContainer()
	{
	}

	[Token(Token = "0x601748B")]
	[Address(RVA = "0x28969A8", Offset = "0x28969A8", VA = "0x28969A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x601748C")]
	[Address(RVA = "0x2896A04", Offset = "0x2896A04", VA = "0x2896A04", Slot = "5")]
	public virtual void OnAddItem(TaskDragDropItem item)
	{
	}

	[Token(Token = "0x601748D")]
	[Address(RVA = "0x2896BF8", Offset = "0x2896BF8", VA = "0x2896BF8", Slot = "6")]
	public virtual void OnRemoveItem(TaskDragDropItem item)
	{
	}

	[Token(Token = "0x601748E")]
	[Address(RVA = "0x2896C78", Offset = "0x2896C78", VA = "0x2896C78", Slot = "7")]
	public virtual bool Check()
	{
		return default(bool);
	}
}
