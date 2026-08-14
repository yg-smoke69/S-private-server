using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003AD2")]
public class TaskItemPicPuzzle : MonoBehaviour
{
	[Token(Token = "0x2003AD3")]
	private sealed class _003CInitDragDrop_003Ec__AnonStorey0
	{
		[Token(Token = "0x4018FE6")]
		[FieldOffset(Offset = "0x8")]
		internal UISprite sprite;

		[Token(Token = "0x4018FE7")]
		[FieldOffset(Offset = "0xC")]
		internal TaskItemPicPuzzle _0024this;

		[Token(Token = "0x60174B1")]
		[Address(RVA = "0x21DCC8C", Offset = "0x21DCC8C", VA = "0x21DCC8C")]
		public _003CInitDragDrop_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60174B2")]
		[Address(RVA = "0x21DCC94", Offset = "0x21DCC94", VA = "0x21DCC94")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4018FE3")]
	[FieldOffset(Offset = "0xC")]
	public TaskDragDropContainer DragDropContainer;

	[Token(Token = "0x4018FE4")]
	[FieldOffset(Offset = "0x10")]
	public TaskDragDropItem DragDropItem;

	[Token(Token = "0x4018FE5")]
	[FieldOffset(Offset = "0x14")]
	private int m_OrgSpriteDepth;

	[Token(Token = "0x60174AF")]
	[Address(RVA = "0x21DC9A0", Offset = "0x21DC9A0", VA = "0x21DC9A0")]
	public TaskItemPicPuzzle()
	{
	}

	[Token(Token = "0x60174B0")]
	[Address(RVA = "0x21DC9A8", Offset = "0x21DC9A8", VA = "0x21DC9A8")]
	public void InitDragDrop(int tag = -1, [Optional] Transform dragdropItemRoot)
	{
	}
}
