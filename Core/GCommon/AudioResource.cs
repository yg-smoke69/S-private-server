using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E4D")]
public class AudioResource : ObjectPoolCallbackBase
{
	[Token(Token = "0x401A594")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID AudioID;

	[Token(Token = "0x401A595")]
	[FieldOffset(Offset = "0x10")]
	public AudioSource Audio;

	[Token(Token = "0x401A596")]
	[FieldOffset(Offset = "0x14")]
	public bool IsNeedUnloadAudioData;

	[Token(Token = "0x401A597")]
	[FieldOffset(Offset = "0x18")]
	public float TargetVolume;

	[Token(Token = "0x401A598")]
	[FieldOffset(Offset = "0x1C")]
	public ObjectPool<AudioResource> OwnedPool;

	[Token(Token = "0x601950B")]
	[Address(RVA = "0x3078A34", Offset = "0x3078A34", VA = "0x3078A34")]
	public AudioResource()
	{
	}

	[Token(Token = "0x601950C")]
	[Address(RVA = "0x3078A3C", Offset = "0x3078A3C", VA = "0x3078A3C", Slot = "8")]
	public override void OnCollected()
	{
	}

	[Token(Token = "0x601950D")]
	[Address(RVA = "0x3078AF4", Offset = "0x3078AF4", VA = "0x3078AF4")]
	public void UnloadAudioData()
	{
	}

	[Token(Token = "0x601950E")]
	[Address(RVA = "0x3078CC4", Offset = "0x3078CC4", VA = "0x3078CC4")]
	public void ReturnToPool()
	{
	}
}
