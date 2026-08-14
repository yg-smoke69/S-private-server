using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004152")]
public class UIMaskEffectSprite : UIEffectSprite
{
	[Token(Token = "0x401B694")]
	[FieldOffset(Offset = "0x1DC")]
	private Shader mShader;

	[Token(Token = "0x401B695")]
	[FieldOffset(Offset = "0x1E0")]
	private Material mMaterial;

	[Token(Token = "0x401B696")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, Dictionary<int, Material>> mCachedAtlasMaterials;

	[Token(Token = "0x17001D61")]
	public override Material material
	{
		[Token(Token = "0x601AAFD")]
		[Address(RVA = "0x2CA607C", Offset = "0x2CA607C", VA = "0x2CA607C", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601AAFC")]
	[Address(RVA = "0x2CA6078", Offset = "0x2CA6078", VA = "0x2CA6078")]
	public UIMaskEffectSprite()
	{
	}

	[Token(Token = "0x601AAFE")]
	[Address(RVA = "0x2CA655C", Offset = "0x2CA655C", VA = "0x2CA655C")]
	public void SetShader(Shader shd)
	{
	}
}
