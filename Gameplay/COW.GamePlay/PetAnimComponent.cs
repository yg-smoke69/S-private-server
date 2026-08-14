using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200086F")]
public class PetAnimComponent : PetAnimComponentBase
{
	[Token(Token = "0x2000870")]
	private sealed class HHINHNMFPHP : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40052EF")]
		[FieldOffset(Offset = "0x8")]
		internal float PODKEPNOBON;

		[Token(Token = "0x40052F0")]
		[FieldOffset(Offset = "0xC")]
		internal PetAnimComponent GADHAMJEKIM;

		[Token(Token = "0x40052F1")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x40052F2")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x40052F3")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000414")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003B3E")]
			[Address(RVA = "0xBC9608", Offset = "0xBC9608", VA = "0xBC9608", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000415")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B3F")]
			[Address(RVA = "0xBC9610", Offset = "0xBC9610", VA = "0xBC9610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0xBC93C0", Offset = "0xBC93C0", VA = "0xBC93C0")]
		public HHINHNMFPHP()
		{
		}

		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0xBC951C", Offset = "0xBC951C", VA = "0xBC951C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B40")]
		[Address(RVA = "0xBC9618", Offset = "0xBC9618", VA = "0xBC9618", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003B41")]
		[Address(RVA = "0xBC962C", Offset = "0xBC962C", VA = "0xBC962C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40052E9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RenderObject;

	[Token(Token = "0x40052EA")]
	[FieldOffset(Offset = "0x3C")]
	public Transform ShowHideEffectPoint;

	[Token(Token = "0x40052EB")]
	[FieldOffset(Offset = "0x40")]
	public AnimationClip AppearAnim;

	[Token(Token = "0x40052EC")]
	[FieldOffset(Offset = "0x44")]
	public AnimationClip DisappearAnim;

	[Token(Token = "0x40052ED")]
	[FieldOffset(Offset = "0x48")]
	public float ShowHideDelay;

	[Token(Token = "0x40052EE")]
	[FieldOffset(Offset = "0x4C")]
	private Action KIHAKDNNNLL;

	[Token(Token = "0x6003B28")]
	[Address(RVA = "0xBC7558", Offset = "0xBC7558", VA = "0xBC7558")]
	public PetAnimComponent()
	{
	}

	[Token(Token = "0x6003B29")]
	[Address(RVA = "0xBC7604", Offset = "0xBC7604", VA = "0xBC7604")]
	public void ChangeAnimCtrlAndModel(GameObject GDOGIGDHJJO, bool NNOEDHLEEAL)
	{
	}

	[Token(Token = "0x6003B2A")]
	[Address(RVA = "0xBC82C0", Offset = "0xBC82C0", VA = "0xBC82C0", Slot = "6")]
	protected override void BMKPIJLAMAP(bool AHJAKPAEBIK, out bool AEODJOOCMBG, out bool OEJKAEIKGNM)
	{
	}

	[Token(Token = "0x6003B2B")]
	[Address(RVA = "0xBC8374", Offset = "0xBC8374", VA = "0xBC8374")]
	public void UpdateAnim(ODFIIFHKNNG HLLGOKLLGEH, byte LEPGEAPLMEO)
	{
	}

	[Token(Token = "0x6003B2C")]
	[Address(RVA = "0xBC8018", Offset = "0xBC8018", VA = "0xBC8018")]
	public void ForceUpdateAnim()
	{
	}

	[Token(Token = "0x6003B2D")]
	[Address(RVA = "0xBC848C", Offset = "0xBC848C", VA = "0xBC848C")]
	private void DKKFJAFOOAH(ODFIIFHKNNG HLLGOKLLGEH, byte LEPGEAPLMEO, bool ANDPBKOAIKH)
	{
	}

	[Token(Token = "0x6003B2E")]
	[Address(RVA = "0xBC8920", Offset = "0xBC8920", VA = "0xBC8920", Slot = "8")]
	protected override void MKOCDHKHEJA()
	{
	}

	[Token(Token = "0x6003B2F")]
	[Address(RVA = "0xBC89F8", Offset = "0xBC89F8", VA = "0xBC89F8", Slot = "9")]
	protected override void FOKKFMKKPFO(ResourceID IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6003B30")]
	[Address(RVA = "0xBC8980", Offset = "0xBC8980", VA = "0xBC8980")]
	private void GOHMJHOPGNK()
	{
	}

	[Token(Token = "0x6003B31")]
	[Address(RVA = "0xBC8A6C", Offset = "0xBC8A6C", VA = "0xBC8A6C")]
	public void ClearShowHideCallback()
	{
	}

	[Token(Token = "0x6003B32")]
	[Address(RVA = "0xBC8540", Offset = "0xBC8540", VA = "0xBC8540")]
	private void LMAOMGJJDPG()
	{
	}

	[Token(Token = "0x6003B33")]
	[Address(RVA = "0xBC87FC", Offset = "0xBC87FC", VA = "0xBC87FC")]
	public void PlayDefaultIdle()
	{
	}

	[Token(Token = "0x6003B34")]
	[Address(RVA = "0xBC8AC8", Offset = "0xBC8AC8", VA = "0xBC8AC8")]
	public void PlayShowAnim(Action IBJIDAEAKED)
	{
	}

	[Token(Token = "0x6003B35")]
	[Address(RVA = "0xBC8DB0", Offset = "0xBC8DB0", VA = "0xBC8DB0")]
	public void PlayHideAnim(Action IBJIDAEAKED)
	{
	}

	[Token(Token = "0x6003B36")]
	[Address(RVA = "0xBC8B74", Offset = "0xBC8B74", VA = "0xBC8B74")]
	private void OFLEKJIJHKH(AnimationClip MBAGEFEJDOA, ResourceID GJMJJFAOBEL, Action IBJIDAEAKED, float PODKEPNOBON)
	{
	}

	[Token(Token = "0x6003B37")]
	[Address(RVA = "0xBC9350", Offset = "0xBC9350", VA = "0xBC9350")]
	public void OnShowHideImmediately(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6003B38")]
	[Address(RVA = "0xBC9254", Offset = "0xBC9254", VA = "0xBC9254")]
	private IEnumerator JLBBENHLCDP(float PODKEPNOBON)
	{
		return null;
	}

	[Token(Token = "0x6003B39")]
	[Address(RVA = "0xBC93C8", Offset = "0xBC93C8", VA = "0xBC93C8")]
	public void _003C_003EiFixBaseProxy_BMKPIJLAMAP(bool P0, out bool P1, out bool P2)
	{
	}

	[Token(Token = "0x6003B3A")]
	[Address(RVA = "0xBC9464", Offset = "0xBC9464", VA = "0xBC9464")]
	public void _003C_003EiFixBaseProxy_MKOCDHKHEJA()
	{
	}

	[Token(Token = "0x6003B3B")]
	[Address(RVA = "0xBC94BC", Offset = "0xBC94BC", VA = "0xBC94BC")]
	public void _003C_003EiFixBaseProxy_FOKKFMKKPFO(ResourceID P0)
	{
	}
}
