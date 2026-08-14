using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003ACD")]
public class TaskDragDropItem : UIDragDropItem
{
	[Token(Token = "0x4018FBB")]
	[FieldOffset(Offset = "0x6C")]
	public int tag;

	[Token(Token = "0x4018FBC")]
	[FieldOffset(Offset = "0x70")]
	public int value;

	[Token(Token = "0x4018FBD")]
	[FieldOffset(Offset = "0x74")]
	public string soundStartDrag;

	[Token(Token = "0x4018FBE")]
	[FieldOffset(Offset = "0x78")]
	public string soundReleaseDrag;

	[Token(Token = "0x4018FBF")]
	[FieldOffset(Offset = "0x7C")]
	public bool IsFinishDragDisableInteract;

	[Token(Token = "0x4018FC0")]
	[FieldOffset(Offset = "0x80")]
	private TaskDragDropContainer m_LastDrop;

	[Token(Token = "0x4018FC1")]
	[FieldOffset(Offset = "0x84")]
	private ResourceID m_resStartDrag;

	[Token(Token = "0x4018FC2")]
	[FieldOffset(Offset = "0x88")]
	private ResourceID m_resReleaseDrag;

	[Token(Token = "0x4018FC3")]
	[FieldOffset(Offset = "0x8C")]
	public Action OnFinishRightRelease;

	[Token(Token = "0x601748F")]
	[Address(RVA = "0x2896CE4", Offset = "0x2896CE4", VA = "0x2896CE4")]
	public TaskDragDropItem()
	{
	}

	[Token(Token = "0x6017490")]
	[Address(RVA = "0x2896D70", Offset = "0x2896D70", VA = "0x2896D70", Slot = "7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6017491")]
	[Address(RVA = "0x2896F50", Offset = "0x2896F50", VA = "0x2896F50", Slot = "18")]
	protected override void OnDragDropStart()
	{
	}

	[Token(Token = "0x6017492")]
	[Address(RVA = "0x2897110", Offset = "0x2897110", VA = "0x2897110", Slot = "20")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x6017493")]
	[Address(RVA = "0x28975BC", Offset = "0x28975BC", VA = "0x28975BC")]
	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	[Token(Token = "0x6017494")]
	[Address(RVA = "0x28975C4", Offset = "0x28975C4", VA = "0x28975C4")]
	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	[Token(Token = "0x6017495")]
	[Address(RVA = "0x28975CC", Offset = "0x28975CC", VA = "0x28975CC")]
	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}
}
