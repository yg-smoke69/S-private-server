using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20023D9")]
public class TrainingSceneRenderGroupPreset : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20023DA")]
	public struct ZoneTypeRender
	{
		[Token(Token = "0x400DECC")]
		[FieldOffset(Offset = "0x0")]
		public IHJOFJKFIBB ZoneType;

		[Token(Token = "0x400DECD")]
		[FieldOffset(Offset = "0x4")]
		public int[] ContainRenderGroup;
	}

	[Token(Token = "0x400DECB")]
	[FieldOffset(Offset = "0xC")]
	public ZoneTypeRender[] ZoneTypeRenders;

	[Token(Token = "0x600CA3C")]
	[Address(RVA = "0x1D85690", Offset = "0x1D85690", VA = "0x1D85690")]
	public TrainingSceneRenderGroupPreset()
	{
	}

	[Token(Token = "0x600CA3D")]
	[Address(RVA = "0x1D85698", Offset = "0x1D85698", VA = "0x1D85698")]
	private void Awake()
	{
	}
}
