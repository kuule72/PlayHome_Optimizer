using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using MethodAttributes = Mono.Cecil.MethodAttributes;
using TypeAttributes = Mono.Cecil.TypeAttributes;

namespace PC_Optimizer_Patchs
{
    public static class OutlinePatcher
    {
        // List of assemblies to patch
        public static IEnumerable<string> TargetDLLs { get; } = new[] { "UnityEngine.UI.dll" };

        // Patches the assemblies
        public static void Patch(AssemblyDefinition assembly)
        {
            var assemblyUtilities = assembly.MainModule.Types.FirstOrDefault(t => t.Name == "Outline");
            var ModifyVertices = assemblyUtilities?.Methods.FirstOrDefault(m => m.Name == "ModifyVertices");

            if (ModifyVertices != null)
            {
                ModifyVertices.Body.Instructions.Clear();
                ModifyVertices.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
            }
        }

    }
}
