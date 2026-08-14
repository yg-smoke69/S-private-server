using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x200013B")]
public class FrontEndPreviewConfig : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200013C")]
	public class PreviewOneConifg
	{
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x8")]
		public PreviewOneItem BagPack;

		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0xC")]
		public PreviewOneItem LootBox;

		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x10")]
		public PreviewOneItem Parachute;

		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x14")]
		public PreviewOneItem SkyBoard;

		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x18")]
		public PreviewOneItem Weapon;

		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x1C")]
		public PreviewOneItem MeleeWeapon;

		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x20")]
		public PreviewOneItem GrenadeWeapon;

		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x24")]
		public PreviewOneItem VehicleSkin;

		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x28")]
		public PreviewOneItem Camera;

		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x2C")]
		public PreviewOneItem RedEnvelope;

		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x30")]
		public PreviewOneItem Pet;

		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x34")]
		public PreviewOneItem Flight;

		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x38")]
		public PreviewOneItem HyperBook;

		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x3C")]
		public PreviewOneItem IceWall;

		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x40")]
		public PreviewOneItem SmokeGrenade;

		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x44")]
		public Dictionary<int, PreviewOneItem> PreviewOneItems;

		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x48")]
		public Vector4 MiddlePoint;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x104B804", Offset = "0x104B804", VA = "0x104B804")]
		public PreviewOneConifg()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200013D")]
	public class PreviewOneItem
	{
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x8")]
		public FrontEndPreviewCameraType CameraType;

		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0xC")]
		public FrontEndPreviewComponent.CollectionPreviewType CollectionPreviewType;

		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 transfrom;

		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 rotation;

		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 scale;

		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x34")]
		public int CameraFov;

		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x38")]
		public bool NeedZoomIn;

		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x39")]
		public bool SpecialViewPort;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x104B80C", Offset = "0x104B80C", VA = "0x104B80C")]
		public PreviewOneItem()
		{
		}
	}

	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0xC")]
	public List<PreviewOneConifg> previewlist;

	[Token(Token = "0x6000794")]
	[Address(RVA = "0x104ADD0", Offset = "0x104ADD0", VA = "0x104ADD0")]
	public FrontEndPreviewConfig()
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x104ADD8", Offset = "0x104ADD8", VA = "0x104ADD8")]
	public void Init()
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x104B58C", Offset = "0x104B58C", VA = "0x104B58C")]
	public PreviewOneConifg GetPreviewItemByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x104B658", Offset = "0x104B658", VA = "0x104B658")]
	public PreviewOneItem GetConfig(int index, FrontEndPreviewComponent.CollectionPreviewType collectionPreviewType)
	{
		return null;
	}
}
