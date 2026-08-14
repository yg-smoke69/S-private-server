using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AD5")]
public class TaskPicturePuzzle : BaseTask
{
	[Token(Token = "0x4018FF3")]
	[FieldOffset(Offset = "0x48")]
	public int SelectFragmentCount;

	[Token(Token = "0x4018FF4")]
	[FieldOffset(Offset = "0x4C")]
	public List<TaskItemPicPuzzle> PicPuzzleList;

	[Token(Token = "0x4018FF5")]
	[FieldOffset(Offset = "0x50")]
	public List<Transform> FragmentShowRoot;

	[Token(Token = "0x4018FF6")]
	[FieldOffset(Offset = "0x54")]
	private List<TaskDragDropContainer> dragDropContainers;

	[Token(Token = "0x4018FF7")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsComplete;

	[Token(Token = "0x4018FF8")]
	[FieldOffset(Offset = "0x0")]
	private static Func<TaskDragDropContainer, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60174BD")]
	[Address(RVA = "0x289A2E4", Offset = "0x289A2E4", VA = "0x289A2E4")]
	public TaskPicturePuzzle()
	{
	}

	[Token(Token = "0x60174BE")]
	[Address(RVA = "0x289A3E0", Offset = "0x289A3E0", VA = "0x289A3E0", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x60174BF")]
	[Address(RVA = "0x289A7BC", Offset = "0x289A7BC", VA = "0x289A7BC")]
	private void CheckComplete()
	{
	}

	[Token(Token = "0x60174C0")]
	[Address(RVA = "0x289A910", Offset = "0x289A910", VA = "0x289A910")]
	private void Update()
	{
	}

	[Token(Token = "0x60174C1")]
	[Address(RVA = "0x289A97C", Offset = "0x289A97C", VA = "0x289A97C")]
	private static bool _003CCheckComplete_003Em__0(TaskDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x60174C2")]
	[Address(RVA = "0x289A9B4", Offset = "0x289A9B4", VA = "0x289A9B4")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
