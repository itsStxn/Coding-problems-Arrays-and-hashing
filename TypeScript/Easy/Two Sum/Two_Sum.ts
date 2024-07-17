export function twoSum(nums: number[], target: number): number[] {
  const indexMap = new Map<number, number>();
  
  for (let i = 0; i < nums.length; i++) {
    const n = nums[i];
    const complementIndex = indexMap.get(n);

    if (complementIndex !== undefined) {
      return [complementIndex, i];
    }
    indexMap.set(target - n, i);
  }

  return [-1, -1];
}
