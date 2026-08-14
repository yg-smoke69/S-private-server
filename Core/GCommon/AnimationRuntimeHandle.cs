using System;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003ED2")]
public class AnimationRuntimeHandle
{
	[Token(Token = "0x401A866")]
	[FieldOffset(Offset = "0x8")]
	protected AnimationSystemComponent m_AnimationSystemComponent;

	[Token(Token = "0x401A867")]
	[FieldOffset(Offset = "0xC")]
	protected AnimationConfigData m_ConfigData;

	[Token(Token = "0x401A868")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_HasFinished;

	[Token(Token = "0x401A869")]
	[FieldOffset(Offset = "0x14")]
	protected int m_CurrentNameHash;

	[Token(Token = "0x401A86A")]
	[FieldOffset(Offset = "0x18")]
	protected float m_LastTime;

	[Token(Token = "0x401A86B")]
	[FieldOffset(Offset = "0x1C")]
	protected AnimationConfigData m_LastData;

	[Token(Token = "0x401A86C")]
	[FieldOffset(Offset = "0x20")]
	protected bool m_IsLooping;

	[Token(Token = "0x401A86D")]
	[FieldOffset(Offset = "0x24")]
	protected Action<float> m_AnimatorCheck;

	[Token(Token = "0x401A86E")]
	[FieldOffset(Offset = "0x28")]
	protected Action m_AnimatorFinishCallBack;

	[Token(Token = "0x401A86F")]
	[FieldOffset(Offset = "0x2C")]
	private uint index;

	[Token(Token = "0x17001BED")]
	public bool IsLooping
	{
		[Token(Token = "0x6019923")]
		[Address(RVA = "0x26B5940", Offset = "0x26B5940", VA = "0x26B5940")]
		set
		{
		}
	}

	[Token(Token = "0x17001BEE")]
	public uint UniqueIndex
	{
		[Token(Token = "0x6019924")]
		[Address(RVA = "0x26B5948", Offset = "0x26B5948", VA = "0x26B5948")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001BEF")]
	public AnimationConfigData configData
	{
		[Token(Token = "0x6019925")]
		[Address(RVA = "0x26B5950", Offset = "0x26B5950", VA = "0x26B5950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019922")]
	[Address(RVA = "0x26B5930", Offset = "0x26B5930", VA = "0x26B5930")]
	public AnimationRuntimeHandle()
	{
	}

	[Token(Token = "0x6019926")]
	[Address(RVA = "0x26B5958", Offset = "0x26B5958", VA = "0x26B5958")]
	public void Reset(AnimationSystemComponent animationSystemComponent, AnimationConfigData data, uint uniqueIndex)
	{
	}

	[Token(Token = "0x6019927")]
	[Address(RVA = "0x26B59A8", Offset = "0x26B59A8", VA = "0x26B59A8")]
	public void SetAction(Action<float> callback)
	{
	}

	[Token(Token = "0x6019928")]
	[Address(RVA = "0x26B59B0", Offset = "0x26B59B0", VA = "0x26B59B0")]
	public void SetFinishCallback(Action callback)
	{
	}

	[Token(Token = "0x6019929")]
	[Address(RVA = "0x26B59B8", Offset = "0x26B59B8", VA = "0x26B59B8")]
	public void CheckEnding(AnimationSystemComponent aniSys, int layer)
	{
	}

	[Token(Token = "0x601992A")]
	[Address(RVA = "0x26B5DF8", Offset = "0x26B5DF8", VA = "0x26B5DF8")]
	public int GetAnimID()
	{
		return default(int);
	}

	[Token(Token = "0x601992B")]
	[Address(RVA = "0x26B5ECC", Offset = "0x26B5ECC", VA = "0x26B5ECC", Slot = "4")]
	protected virtual void OnReset()
	{
	}

	[Token(Token = "0x601992C")]
	[Address(RVA = "0x26B5ED0", Offset = "0x26B5ED0", VA = "0x26B5ED0")]
	internal void SetAnimationFinished()
	{
	}

	[Token(Token = "0x601992D")]
	[Address(RVA = "0x26B5EF8", Offset = "0x26B5EF8", VA = "0x26B5EF8", Slot = "5")]
	public virtual bool CanInterrupted()
	{
		return default(bool);
	}
}
