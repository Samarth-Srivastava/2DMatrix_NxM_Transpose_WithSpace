class Solution {
    public List<List<int>> solve(List<List<int>> A) {
        int N = A.Count();
        int M = A[0].Count();
        List<List<int>> B = new List<List<int>>();
        for(int i = 0; i < M; i++){
            List<int> inner = new List<int>();
            for(int j = 0; j < N; j++){
                inner.Add(A[j][i]);
            }
            B.Add(inner);
        }
        return B;
    }
}
