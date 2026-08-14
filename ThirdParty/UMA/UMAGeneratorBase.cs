using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CDB")]
public abstract class UMAGeneratorBase : MonoBehaviour
{
	[Token(Token = "0x2003CDC")]
	public class AnimatorState
	{
		[Token(Token = "0x4019D9E")]
		[FieldOffset(Offset = "0x8")]
		private int[] stateHashes;

		[Token(Token = "0x4019D9F")]
		[FieldOffset(Offset = "0xC")]
		private float[] stateTimes;

		[Token(Token = "0x4019DA0")]
		[FieldOffset(Offset = "0x10")]
		private AnimatorControllerParameter[] parameters;

		[Token(Token = "0x60185BA")]
		[Address(RVA = "0x2E01ECC", Offset = "0x2E01ECC", VA = "0x2E01ECC")]
		public AnimatorState()
		{
		}

		[Token(Token = "0x60185BB")]
		[Address(RVA = "0x2E01F5C", Offset = "0x2E01F5C", VA = "0x2E01F5C")]
		public void SaveAnimatorState(Animator animator)
		{
		}

		[Token(Token = "0x60185BC")]
		[Address(RVA = "0x2E023E0", Offset = "0x2E023E0", VA = "0x2E023E0")]
		public void RestoreAnimatorState(Animator animator)
		{
		}
	}

	[Token(Token = "0x4019D98")]
	[FieldOffset(Offset = "0xC")]
	public bool fitAtlas;

	[Token(Token = "0x4019D99")]
	[FieldOffset(Offset = "0x10")]
	public TextureMerge textureMerge;

	[Token(Token = "0x4019D9A")]
	[FieldOffset(Offset = "0x14")]
	public bool convertRenderTexture;

	[Token(Token = "0x4019D9B")]
	[FieldOffset(Offset = "0x15")]
	public bool convertMipMaps;

	[Token(Token = "0x4019D9C")]
	[FieldOffset(Offset = "0x18")]
	public int atlasResolution;

	[Token(Token = "0x4019D9D")]
	[FieldOffset(Offset = "0x0")]
	protected static UMAGeneratorBase Instance;

	[Token(Token = "0x60185A9")]
	[Address(RVA = "0x2E017B8", Offset = "0x2E017B8", VA = "0x2E017B8")]
	protected UMAGeneratorBase()
	{
	}

	[Token(Token = "0x60185AA")]
	public abstract void addDirtyUMA(UMAData umaToAdd);

	[Token(Token = "0x60185AB")]
	public abstract bool IsIdle();

	[Token(Token = "0x60185AC")]
	public abstract int QueueSize();

	[Token(Token = "0x60185AD")]
	public abstract void Work();

	[Token(Token = "0x60185AE")]
	public abstract void WorkSync(UMAData umadata);

	[Token(Token = "0x60185AF")]
	public abstract void RemoveData(UMAData umadata);

	[Token(Token = "0x60185B0")]
	[Address(RVA = "0x2DFAF88", Offset = "0x2DFAF88", VA = "0x2DFAF88")]
	public static UMAGeneratorBase FindInstance()
	{
		return null;
	}

	[Token(Token = "0x60185B1")]
	[Address(RVA = "0x2E017C0", Offset = "0x2E017C0", VA = "0x2E017C0", Slot = "10")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60185B2")]
	[Address(RVA = "0x2E01884", Offset = "0x2E01884", VA = "0x2E01884", Slot = "11")]
	public virtual void UpdateAvatar(UMAData umaData)
	{
	}

	[Token(Token = "0x60185B3")]
	[Address(RVA = "0x2E01DE8", Offset = "0x2E01DE8", VA = "0x2E01DE8")]
	public static void SetAvatar(UMAData umaData, Animator animator)
	{
	}

	[Token(Token = "0x60185B4")]
	[Address(RVA = "0x2E028B8", Offset = "0x2E028B8", VA = "0x2E028B8")]
	public static void DebugLogHumanAvatar(GameObject root, HumanDescription description)
	{
	}

	[Token(Token = "0x60185B5")]
	[Address(RVA = "0x2E02754", Offset = "0x2E02754", VA = "0x2E02754")]
	public static Avatar CreateAvatar(UMAData umaData, UmaTPose umaTPose)
	{
		return null;
	}

	[Token(Token = "0x60185B6")]
	[Address(RVA = "0x2E02834", Offset = "0x2E02834", VA = "0x2E02834")]
	public static Avatar CreateGenericAvatar(UMAData umaData)
	{
		return null;
	}

	[Token(Token = "0x60185B7")]
	[Address(RVA = "0x2E02D08", Offset = "0x2E02D08", VA = "0x2E02D08")]
	public static HumanDescription CreateHumanDescription(UMAData umaData, UmaTPose umaTPose)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(HumanDescription);
	}

	[Token(Token = "0x60185B8")]
	[Address(RVA = "0x2E03610", Offset = "0x2E03610", VA = "0x2E03610")]
	private void ModifySkeletonBone(ref SkeletonBone bone, Transform trans)
	{
	}

	[Token(Token = "0x60185B9")]
	[Address(RVA = "0x2E02E14", Offset = "0x2E02E14", VA = "0x2E02E14")]
	private static void SkeletonModifier(UMAData umaData, ref SkeletonBone[] bones, ref HumanBone[] human)
	{
	}
}
