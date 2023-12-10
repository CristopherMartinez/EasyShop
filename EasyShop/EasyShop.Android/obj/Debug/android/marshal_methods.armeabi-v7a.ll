; ModuleID = 'obj/Debug/android/marshal_methods.armeabi-v7a.ll'
source_filename = "obj/Debug/android/marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [174 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 45
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 75
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 8
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 70
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 59
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 59
	i32 165246403, ; 6: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 26
	i32 182336117, ; 7: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 60
	i32 202624640, ; 8: Xamarin.Forms.BehaviorsPack => 0xc13ce80 => 69
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 24
	i32 230216969, ; 10: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 40
	i32 232815796, ; 11: System.Web.Services => 0xde07cb4 => 85
	i32 261689757, ; 12: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 29
	i32 278686392, ; 13: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 44
	i32 280482487, ; 14: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 38
	i32 318968648, ; 15: Xamarin.AndroidX.Activity.dll => 0x13031348 => 16
	i32 321597661, ; 16: System.Numerics => 0x132b30dd => 11
	i32 336255045, ; 17: EasyShop.dll => 0x140ad845 => 3
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 42
	i32 441335492, ; 19: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 28
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 68
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 37
	i32 465846621, ; 22: mscorlib => 0x1bc4415d => 7
	i32 469710990, ; 23: System.dll => 0x1bff388e => 10
	i32 476646585, ; 24: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 38
	i32 486930444, ; 25: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 49
	i32 526420162, ; 26: System.Transactions.dll => 0x1f6088c2 => 79
	i32 605376203, ; 27: System.IO.Compression.FileSystem => 0x24154ecb => 83
	i32 627609679, ; 28: Xamarin.AndroidX.CustomView => 0x2568904f => 33
	i32 663517072, ; 29: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 65
	i32 666292255, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 21
	i32 690569205, ; 31: System.Xml.Linq.dll => 0x29293ff5 => 15
	i32 775507847, ; 32: System.IO.Compression => 0x2e394f87 => 82
	i32 809851609, ; 33: System.Drawing.Common.dll => 0x30455ad9 => 81
	i32 843511501, ; 34: Xamarin.AndroidX.Print => 0x3246f6cd => 56
	i32 928116545, ; 35: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 75
	i32 955402788, ; 36: Newtonsoft.Json => 0x38f24a24 => 8
	i32 967690846, ; 37: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 42
	i32 974778368, ; 38: FormsViewGroup.dll => 0x3a19f000 => 4
	i32 1012816738, ; 39: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 58
	i32 1035644815, ; 40: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 20
	i32 1042160112, ; 41: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 72
	i32 1052210849, ; 42: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 46
	i32 1098259244, ; 43: System => 0x41761b2c => 10
	i32 1175144683, ; 44: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 63
	i32 1178241025, ; 45: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 53
	i32 1204270330, ; 46: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 21
	i32 1267360935, ; 47: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 64
	i32 1293217323, ; 48: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 35
	i32 1365406463, ; 49: System.ServiceModel.Internals.dll => 0x516272ff => 76
	i32 1376866003, ; 50: Xamarin.AndroidX.SavedState => 0x52114ed3 => 58
	i32 1395857551, ; 51: Xamarin.AndroidX.Media.dll => 0x5333188f => 50
	i32 1406073936, ; 52: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 30
	i32 1460219004, ; 53: Xamarin.Forms.Xaml => 0x57092c7c => 73
	i32 1462112819, ; 54: System.IO.Compression.dll => 0x57261233 => 82
	i32 1469204771, ; 55: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 19
	i32 1582372066, ; 56: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 34
	i32 1592978981, ; 57: System.Runtime.Serialization.dll => 0x5ef2ee25 => 2
	i32 1600811301, ; 58: EasyShop.Android.dll => 0x5f6a7125 => 0
	i32 1622152042, ; 59: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 48
	i32 1624863272, ; 60: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 67
	i32 1636350590, ; 61: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 32
	i32 1639515021, ; 62: System.Net.Http.dll => 0x61b9038d => 1
	i32 1657153582, ; 63: System.Runtime => 0x62c6282e => 13
	i32 1658241508, ; 64: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 61
	i32 1658251792, ; 65: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 74
	i32 1670060433, ; 66: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 29
	i32 1729485958, ; 67: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 25
	i32 1766324549, ; 68: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 60
	i32 1776026572, ; 69: System.Core.dll => 0x69dc03cc => 9
	i32 1788241197, ; 70: Xamarin.AndroidX.Fragment => 0x6a96652d => 37
	i32 1808609942, ; 71: Xamarin.AndroidX.Loader => 0x6bcd3296 => 48
	i32 1813201214, ; 72: Xamarin.Google.Android.Material => 0x6c13413e => 74
	i32 1818569960, ; 73: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 54
	i32 1867746548, ; 74: Xamarin.Essentials.dll => 0x6f538cf4 => 68
	i32 1878053835, ; 75: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 73
	i32 1885316902, ; 76: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 22
	i32 1919157823, ; 77: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 51
	i32 2019465201, ; 78: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 46
	i32 2055257422, ; 79: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 43
	i32 2079903147, ; 80: System.Runtime.dll => 0x7bf8cdab => 13
	i32 2090596640, ; 81: System.Numerics.Vectors => 0x7c9bf920 => 12
	i32 2097448633, ; 82: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 39
	i32 2126786730, ; 83: Xamarin.Forms.Platform.Android => 0x7ec430aa => 71
	i32 2201231467, ; 84: System.Net.Http => 0x8334206b => 1
	i32 2217644978, ; 85: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 63
	i32 2244775296, ; 86: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 49
	i32 2256548716, ; 87: Xamarin.AndroidX.MultiDex => 0x8680336c => 51
	i32 2261435625, ; 88: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 41
	i32 2279755925, ; 89: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 57
	i32 2315684594, ; 90: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 17
	i32 2324597308, ; 91: EasyShop.Android => 0x8a8e8a3c => 0
	i32 2409053734, ; 92: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 55
	i32 2465532216, ; 93: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 28
	i32 2471841756, ; 94: netstandard.dll => 0x93554fdc => 77
	i32 2475788418, ; 95: Java.Interop.dll => 0x93918882 => 5
	i32 2501346920, ; 96: System.Data.DataSetExtensions => 0x95178668 => 80
	i32 2505896520, ; 97: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 45
	i32 2581819634, ; 98: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 64
	i32 2620871830, ; 99: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 32
	i32 2624644809, ; 100: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 36
	i32 2633051222, ; 101: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 44
	i32 2701096212, ; 102: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 61
	i32 2704244781, ; 103: EasyShop => 0xa12f802d => 3
	i32 2732626843, ; 104: Xamarin.AndroidX.Activity => 0xa2e0939b => 16
	i32 2737747696, ; 105: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 19
	i32 2766581644, ; 106: Xamarin.Forms.Core => 0xa4e6af8c => 70
	i32 2778768386, ; 107: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 66
	i32 2810250172, ; 108: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 30
	i32 2819470561, ; 109: System.Xml.dll => 0xa80db4e1 => 14
	i32 2853208004, ; 110: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 66
	i32 2855708567, ; 111: Xamarin.AndroidX.Transition => 0xaa36a797 => 62
	i32 2903344695, ; 112: System.ComponentModel.Composition => 0xad0d8637 => 84
	i32 2905242038, ; 113: mscorlib.dll => 0xad2a79b6 => 7
	i32 2916838712, ; 114: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 67
	i32 2919462931, ; 115: System.Numerics.Vectors.dll => 0xae037813 => 12
	i32 2921128767, ; 116: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 18
	i32 2978675010, ; 117: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 35
	i32 3024354802, ; 118: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 40
	i32 3044182254, ; 119: FormsViewGroup => 0xb57288ee => 4
	i32 3057625584, ; 120: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 52
	i32 3111772706, ; 121: System.Runtime.Serialization => 0xb979e222 => 2
	i32 3204380047, ; 122: System.Data.dll => 0xbefef58f => 78
	i32 3211777861, ; 123: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 34
	i32 3247949154, ; 124: Mono.Security => 0xc197c562 => 86
	i32 3258312781, ; 125: Xamarin.AndroidX.CardView => 0xc235e84d => 25
	i32 3267021929, ; 126: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 23
	i32 3317135071, ; 127: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 33
	i32 3317144872, ; 128: System.Data => 0xc5b79d28 => 78
	i32 3340431453, ; 129: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 22
	i32 3346324047, ; 130: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 53
	i32 3353484488, ; 131: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 39
	i32 3362522851, ; 132: Xamarin.AndroidX.Core => 0xc86c06e3 => 31
	i32 3366347497, ; 133: Java.Interop => 0xc8a662e9 => 5
	i32 3374999561, ; 134: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 57
	i32 3404865022, ; 135: System.ServiceModel.Internals => 0xcaf21dfe => 76
	i32 3429136800, ; 136: System.Xml => 0xcc6479a0 => 14
	i32 3430777524, ; 137: netstandard => 0xcc7d82b4 => 77
	i32 3441283291, ; 138: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 36
	i32 3476120550, ; 139: Mono.Android => 0xcf3163e6 => 6
	i32 3486566296, ; 140: System.Transactions => 0xcfd0c798 => 79
	i32 3493954962, ; 141: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 27
	i32 3501239056, ; 142: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 23
	i32 3509114376, ; 143: System.Xml.Linq => 0xd128d608 => 15
	i32 3536029504, ; 144: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 71
	i32 3567349600, ; 145: System.ComponentModel.Composition.dll => 0xd4a16f60 => 84
	i32 3618140916, ; 146: Xamarin.AndroidX.Preference => 0xd7a872f4 => 55
	i32 3627220390, ; 147: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 56
	i32 3632359727, ; 148: Xamarin.Forms.Platform => 0xd881692f => 72
	i32 3633644679, ; 149: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 18
	i32 3641597786, ; 150: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 43
	i32 3645376713, ; 151: Xamarin.Forms.BehaviorsPack.dll => 0xd94808c9 => 69
	i32 3672681054, ; 152: Mono.Android.dll => 0xdae8aa5e => 6
	i32 3676310014, ; 153: System.Web.Services.dll => 0xdb2009fe => 85
	i32 3682565725, ; 154: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 24
	i32 3684561358, ; 155: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 27
	i32 3689375977, ; 156: System.Drawing.Common => 0xdbe768e9 => 81
	i32 3718780102, ; 157: Xamarin.AndroidX.Annotation => 0xdda814c6 => 17
	i32 3724971120, ; 158: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 52
	i32 3758932259, ; 159: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 41
	i32 3786282454, ; 160: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 26
	i32 3822602673, ; 161: Xamarin.AndroidX.Media => 0xe3d849b1 => 50
	i32 3829621856, ; 162: System.Numerics.dll => 0xe4436460 => 11
	i32 3885922214, ; 163: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 62
	i32 3896760992, ; 164: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 31
	i32 3920810846, ; 165: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 83
	i32 3921031405, ; 166: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 65
	i32 3931092270, ; 167: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 54
	i32 3945713374, ; 168: System.Data.DataSetExtensions.dll => 0xeb2ecede => 80
	i32 3955647286, ; 169: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 20
	i32 4105002889, ; 170: Mono.Security.dll => 0xf4ad5f89 => 86
	i32 4151237749, ; 171: System.Core => 0xf76edc75 => 9
	i32 4182413190, ; 172: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 47
	i32 4292120959 ; 173: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 47
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [174 x i32] [
	i32 45, i32 75, i32 8, i32 70, i32 59, i32 59, i32 26, i32 60, ; 0..7
	i32 69, i32 24, i32 40, i32 85, i32 29, i32 44, i32 38, i32 16, ; 8..15
	i32 11, i32 3, i32 42, i32 28, i32 68, i32 37, i32 7, i32 10, ; 16..23
	i32 38, i32 49, i32 79, i32 83, i32 33, i32 65, i32 21, i32 15, ; 24..31
	i32 82, i32 81, i32 56, i32 75, i32 8, i32 42, i32 4, i32 58, ; 32..39
	i32 20, i32 72, i32 46, i32 10, i32 63, i32 53, i32 21, i32 64, ; 40..47
	i32 35, i32 76, i32 58, i32 50, i32 30, i32 73, i32 82, i32 19, ; 48..55
	i32 34, i32 2, i32 0, i32 48, i32 67, i32 32, i32 1, i32 13, ; 56..63
	i32 61, i32 74, i32 29, i32 25, i32 60, i32 9, i32 37, i32 48, ; 64..71
	i32 74, i32 54, i32 68, i32 73, i32 22, i32 51, i32 46, i32 43, ; 72..79
	i32 13, i32 12, i32 39, i32 71, i32 1, i32 63, i32 49, i32 51, ; 80..87
	i32 41, i32 57, i32 17, i32 0, i32 55, i32 28, i32 77, i32 5, ; 88..95
	i32 80, i32 45, i32 64, i32 32, i32 36, i32 44, i32 61, i32 3, ; 96..103
	i32 16, i32 19, i32 70, i32 66, i32 30, i32 14, i32 66, i32 62, ; 104..111
	i32 84, i32 7, i32 67, i32 12, i32 18, i32 35, i32 40, i32 4, ; 112..119
	i32 52, i32 2, i32 78, i32 34, i32 86, i32 25, i32 23, i32 33, ; 120..127
	i32 78, i32 22, i32 53, i32 39, i32 31, i32 5, i32 57, i32 76, ; 128..135
	i32 14, i32 77, i32 36, i32 6, i32 79, i32 27, i32 23, i32 15, ; 136..143
	i32 71, i32 84, i32 55, i32 56, i32 72, i32 18, i32 43, i32 69, ; 144..151
	i32 6, i32 85, i32 24, i32 27, i32 81, i32 17, i32 52, i32 41, ; 152..159
	i32 26, i32 50, i32 11, i32 62, i32 31, i32 83, i32 65, i32 54, ; 160..167
	i32 80, i32 20, i32 86, i32 9, i32 47, i32 47 ; 168..173
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
