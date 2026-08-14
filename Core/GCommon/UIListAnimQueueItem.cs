using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004151")]
public class UIListAnimQueueItem : MonoBehaviour
{
	[Token(Token = "0x401B68A")]
	[FieldOffset(Offset = "0xC")]
	public TweenAlpha TweenA;

	[Token(Token = "0x401B68B")]
	[FieldOffset(Offset = "0x10")]
	public TweenPosition TweenPos;

	[Token(Token = "0x401B68C")]
	[FieldOffset(Offset = "0x14")]
	public TweenRotation TweenRot;

	[Token(Token = "0x401B68D")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale TweenS;

	[Token(Token = "0x401B68E")]
	[FieldOffset(Offset = "0x1C")]
	public Animation Animation_;

	[Token(Token = "0x401B68F")]
	[FieldOffset(Offset = "0x20")]
	public Animator Animator_;

	[Token(Token = "0x401B690")]
	[FieldOffset(Offset = "0x24")]
	private int m_LastIndex;

	[Token(Token = "0x401B691")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Played;

	[Token(Token = "0x401B692")]
	[FieldOffset(Offset = "0x2C")]
	private UIEasyListItemController m_EasyListItemCtrl;

	[Token(Token = "0x401B693")]
	[FieldOffset(Offset = "0x30")]
	public Func<int> GetLastPlayIndex;

	[Token(Token = "0x601AAF5")]
	[Address(RVA = "0x2CA4F44", Offset = "0x2CA4F44", VA = "0x2CA4F44")]
	public UIListAnimQueueItem()
	{
	}

	[Token(Token = "0x601AAF6")]
	[Address(RVA = "0x2CA4CDC", Offset = "0x2CA4CDC", VA = "0x2CA4CDC")]
	public void AutoFindAnim()
	{
	}

	[Token(Token = "0x601AAF7")]
	[Address(RVA = "0x2CA4F54", Offset = "0x2CA4F54", VA = "0x2CA4F54")]
	private void DisableAnim()
	{
	}

	[Token(Token = "0x601AAF8")]
	[Address(RVA = "0x2CA5228", Offset = "0x2CA5228", VA = "0x2CA5228")]
	private void PlayAnim()
	{
	}

	[Token(Token = "0x601AAF9")]
	[Address(RVA = "0x2CA5560", Offset = "0x2CA5560", VA = "0x2CA5560")]
	private void ResetToBegining()
	{
	}

	[Token(Token = "0x601AAFA")]
	[Address(RVA = "0x2CA58C8", Offset = "0x2CA58C8", VA = "0x2CA58C8")]
	private void ResetToEnd()
	{
	}

	[Token(Token = "0x601AAFB")]
	[Address(RVA = "0x2CA5DF0", Offset = "0x2CA5DF0", VA = "0x2CA5DF0")]
	private void Update()
	{
	}
}
